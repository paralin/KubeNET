#!/bin/bash
set -e

# Get current git hash
HASH=$(git rev-parse --verify HEAD --short)

if [ ! -d swagger_codegen ]; then
  echo "Cloning swagger-codegen..."
  git clone https://github.com/swagger-api/swagger-codegen.git swagger_codegen --depth=1
  pushd swagger_codegen
  ./run-in-docker.sh mvn package
  popd
fi
pushd swagger_codegen

echo "Compiling code..."
sed -e "s/{{gitid}}/${HASH}/gi/" ../config.json > ./config.json
cp ../../../API/kubernetes.swagger ./
./run-in-docker.sh generate \
  -i /gen/kubernetes.swagger \
  -l csharp \
  -o output/csharp/ \
  -c config.json
popd
