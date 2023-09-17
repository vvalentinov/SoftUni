const { getImage, getCss } = require('../utils/getFile');

const staticRouter = async (req, res) => {
    if (req.url.endsWith('site.css')) {
        const siteCss = await getCss();

        res.writeHead(200, { 'Content-Type': 'text/css' });
        res.write(siteCss);
        res.end();
    } else if (req.url.endsWith('.ico')) {
        const favicon = await getImage('favicon.ico');

        res.writeHead(200, { 'Content-Type': 'image/x-icon' });
        res.write(favicon);
        res.end();
    } else if (req.url.endsWith('.png') || req.url.endsWith('.jpg') || req.url.endsWith('.jpeg')) {
        const imageName = req.url.substring(1);
        const image = await getImage(imageName, 'catsImages');

        res.writeHead(200, { 'Content-Type': 'image/jpeg' });
        res.write(image);
        res.end();
    }
};

module.exports = staticRouter;