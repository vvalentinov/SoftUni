const { getHtml } = require('./getFile');

exports.errorMessage = async (res, errorMessage) => {
    let errorHtml = await getHtml('error');
    errorHtml = errorHtml.replace('{{error}}', `${errorMessage}`);
    res.writeHead(200, { 'Content-Type': 'text/html' });
    res.write(errorHtml);
    res.end();
};