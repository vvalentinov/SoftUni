const fs = require('fs/promises');
const path = require('path');

const { addBreedToDb } = require('../services/breedsService');

const catRouter = async (req, res) => {
    if (req.url == '/cats/add-breed' && req.method === 'GET') {
        const addBreedHtmlPath = path.resolve(__dirname, '../views/addBreed.html');
        const addBreedHtml = await fs.readFile(addBreedHtmlPath);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addBreedHtml);
        res.end();
    } else if (req.url == '/cats/add-breed' && req.method === 'POST') {
        req.on('data', async (data) => {
            const input = data.toString().split('=')[1];
            const breed = input.replaceAll('+', ' ');

            await addBreedToDb(breed);
        });

        res.writeHead(301, { Location: '/' });
        res.end();
    } else if (req.url == '/cats/add-cat') {
        const addCatHtmlPath = path.resolve(__dirname, '../views/addCat.html');
        const addCatHtml = await fs.readFile(addCatHtmlPath);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addCatHtml);
        res.end();
    }
};

module.exports = catRouter;