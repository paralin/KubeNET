#!/bin/bash
set -e

echo "Cloning kubernetes..."
git clone https://github.com/kubernetes/kubernetes.git kubernetes --depth=1

echo "Compiling swagger..."
cp kubernetes/api/swagger-spec/*.json .
rm -rf kubernetes
node convert.js > /usr/output/kubernetes.swagger
