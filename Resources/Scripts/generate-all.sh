#!/bin/bash

cd ./gen-swagger2 && ./generate-docker.sh && cd -
cd ./gen-csharp && ./generate.sh && cd -
