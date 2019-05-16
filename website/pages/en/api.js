const React = require('react');
const convert = require('xml-js');
const fs = require('fs');

const apiPath = process.cwd() + '/core/api.xml';
const apiXML = fs.readFileSync(apiPath);
const api = convert.xml2js(apiXML);
const marvelousAPI = api.elements[0].elements[1].elements;
console.log('api', api.elements[0].elements[1].elements[0]);

class Index extends React.Component {
  componentDidMount() {
    console.log("123");
    fetch('http://localhost:3000/marvelous/api.htmlmarvelous/api.xml').then((xml) => {
      console.log(xml);
    });
  }
  render() {

    return (<>
      {marvelousAPI.map((func) => {
        return(
          <div>
            <h1>{func.attributes.name}</h1>
            {func.elements.map((attrs) => {
              return(
                <>
                  <p>
                    {attrs.name}
                    {attrs.attributes && attrs.attributes.name  && <span> - {attrs.attributes.name}</span>}
                    {attrs.elements && attrs.elements[0] && attrs.elements[0].text && <span> - {attrs.elements[0].text}</span>}
                  </p>
                  {/* <span>{JSON.stringify(attrs)}</span> */}
                </>
              );
            })}
          </div>
        );
      })}
    </>);
  }
}

module.exports = Index;
