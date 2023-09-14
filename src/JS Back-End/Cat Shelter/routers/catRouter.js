const fs = require('fs/promises');
const path = require('path');

const catRouter = async (req, res) => {
    if (req.url == '/cats/add-breed') {
        const addBreedHtmlPath = path.resolve(__dirname, '../views/addBreed.html');
        const addBreedHtml = await fs.readFile(addBreedHtmlPath);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addBreedHtml);
        res.end();
    }
};

module.exports = catRouter;