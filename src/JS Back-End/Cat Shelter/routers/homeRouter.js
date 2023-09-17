const { generateHomeHtml } = require('../utils/generateHtml');

const homeRouter = async (req, res) => {
    if (req.url == '/') {
        const homeHtml = await generateHomeHtml();

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(homeHtml);
        res.end();
    }
};

module.exports = homeRouter;