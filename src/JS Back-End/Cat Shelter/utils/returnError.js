const { generateErrorHtml } = require('../utils/generateHtml');

exports.errorMessage = async (res, errorMessage) => {
    const errorHtml = await generateErrorHtml(`${errorMessage}`);
    res.writeHead(200, { 'Content-Type': 'text/html' });
    res.write(errorHtml);
    res.end();
};