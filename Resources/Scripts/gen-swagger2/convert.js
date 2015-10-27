var convert = require('swagger-converter');
var fs = require('fs');

var resourceListing = require('./resourceListing.json');

var files = fs.readdirSync(".");

var apiDeclarations = [];

files.forEach(function(file) {
  if (file.endsWith(".json") && file.indexOf("resourceListing") == -1 && file.indexOf("package.json") == -1) {
    apiDeclarations.push(require("./" + file));
  }
});

var swagger2Document = convert(resourceListing, apiDeclarations);

console.log(JSON.stringify(swagger2Document, null, 2));
