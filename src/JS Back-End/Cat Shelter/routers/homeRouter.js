const fs = require('fs/promises');
const path = require('path');

const homeRouter = async (req, res) => {
    if (req.url == '/') {
        const homeHtmlPath = path.resolve(__dirname, '../views/home/index.html');
        const homeHtml = await fs.readFile(homeHtmlPath);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(homeHtml);
        res.end();
    }
};

module.exports = homeRouter;