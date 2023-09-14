const http = require('http');
const fs = require('fs/promises');
const path = require('path');

const port = 5001;

const server = http.createServer(async (req, res) => {
    if (req.url == '/') {
        const homeHtmlPath = path.resolve(__dirname, './views/home/index.html');
        const homeHtml = await fs.readFile(homeHtmlPath);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(homeHtml);
        res.end();
    } else if (req.url.endsWith('site.css')) {
        const siteCssPath = path.resolve(__dirname, './content/styles/site.css');
        const siteCss = await fs.readFile(siteCssPath);

        res.writeHead(200, { 'Content-Type': 'text/css' });
        res.write(siteCss);
        res.end();
    } else if (req.url.endsWith('pawprint.ico')) {
        const pawprintIcoPath = path.resolve(__dirname, './content/images/pawprint.ico');
        const pawprintIco = await fs.readFile(pawprintIcoPath);

        res.writeHead(200, { 'Content-Type': 'image/png' });
        res.write(pawprintIco);
        res.end();
    }
});

server.listen(port, () => console.log(`Server is listening on port ${port}...`));