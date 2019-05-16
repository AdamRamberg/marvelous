const React = require('react');
const convert = require('xml-js');
const fs = require('fs');

const apiPath = process.cwd() + '/core/api.xml';
const apiXML = fs.readFileSync(apiPath);
const api = convert.xml2js(apiXML);
const marvelousAPI = api.elements[0].elements[1].elements;

class Index extends React.Component {
  render() {
    return (
      <div>
        {marvelousAPI.map((func) => {
          return(
            <div>
              <h1>{func.attributes.name}</h1>
              {func.elements.map((attrs) => {
                return(
                  <div>
                    <p>
                      {attrs.name}
                      {attrs.attributes && attrs.attributes.name  && <span> - {attrs.attributes.name}</span>}
                      {attrs.elements && attrs.elements[0] && attrs.elements[0].text && <span> - {attrs.elements[0].text}</span>}
                    </p>
                    {/* <span>{JSON.stringify(attrs)}</span> */}
                  </div>
                );
              })}
            </div>
          );
        })}
      </div>
    );
  }
}

module.exports = Index;
