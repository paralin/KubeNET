#!/bin/bash

docker build -t cskube/gen-swagger2 .
docker run -it -v `pwd`/:/usr/output/ cskube/gen-swagger2
mv -f kubernetes.swagger ../../API/
