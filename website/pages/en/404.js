const React = require("react");
const siteConfig = require(`${process.cwd()}/siteConfig.js`);

class ErrorPage extends React.Component {
  render() {
    const {siteConfig} = this.props;

    return (
      <div className="error-page">
        <div className="error-message">
          <div className=" error-message-container container">
            <span>404 </span>
            <p>Page Not Found.</p>
            <a href={siteConfig.baseUrl}>Return to the front page</a>
          </div>
        </div>
      </div>
    );
  }
}

ErrorPage.title = "Page Not Found"


module.exports = ErrorPage;
