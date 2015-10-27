FROM node:4.2.1

WORKDIR /usr/src
ADD convert.js package.json generate.sh /usr/src/
RUN npm install

VOLUME ["/usr/output/"]
CMD bash generate.sh
