#!/bin/bash
set -e

# Get current git hash
HASH=$(git rev-parse --verify HEAD --short)
MYPATH=`pwd`

if [ ! -d swagger_codegen ]; then
  echo "Cloning swagger-codegen..."
  git clone https://github.com/paralin/swagger-codegen.git swagger_codegen --depth=1
  pushd swagger_codegen
  ./run-in-docker.sh mvn package
  popd
fi

pushd swagger_codegen

echo "Compiling code..."

sed -e "s/{{gitid}}/${HASH}/gi" ../config.json > ./config.json

cp ../../../API/kubernetes.swagger ./
./run-in-docker.sh generate \
  -i /gen/kubernetes.swagger \
  -l csharp \
  -o output/csharp/ \
  -c config.json
popd
pushd ../../../KubeNET/

rm -rf Swagger/
cp -r $MYPATH/swagger_codegen/output/csharp/src/main/csharp/KubeNET/Swagger/ ./Swagger/
FILES=$(find * -name "*.cs" -type f)
ITEMGROUP="  <ItemGroup generatedimports=\"\">"
while read -r line; do
  ITEMGROUP="$ITEMGROUP\n    <Compile Include=\"$line\"/>"
done <<< "$FILES"
ITEMGROUP="$ITEMGROUP\n  </ItemGroup>\n</Project>"
sed -i -e '/generatedimports/,/ItemGroup/d' KubeNET.csproj
sed -i '$ d' KubeNET.csproj
echo -e $ITEMGROUP >> KubeNET.csproj
popd
