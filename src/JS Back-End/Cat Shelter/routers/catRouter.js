const { addBreedToDb } = require('../services/breedsService');
const { getHtml, getDbCollection } = require('../utils/getFile');
const { errorMessage } = require('../utils/returnError');

const catRouter = async (req, res) => {
    if (req.url == '/cats/add-breed' && req.method === 'GET') {
        const addBreedHtml = await getHtml('addBreed');
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addBreedHtml);
        res.end();
    } else if (req.url == '/cats/add-breed' && req.method === 'POST') {
        let requestData = '';
        req.on('data', async (chunk) => {
            requestData += chunk;
        });

        req.on('end', async () => {
            if (requestData == 'breed=') {
                return await errorMessage(res, 'You have to add breed name!');
            } else {
                const input = requestData.toString().split('=')[1];
                const breed = input.replaceAll('+', ' ');

                const regex = new RegExp('^(?:[A-Za-z]+(?: [A-Za-z]+)*(?: [A-Za-z]+)?)?$');
                if (!regex.test(breed)) {
                    return await errorMessage(res, 'The breed is not in the correct format!');
                }

                const breedsDb = await getDbCollection('breeds');
                const breeds = Object.values(JSON.parse(breedsDb));

                if (breeds.includes(breed)) {
                    return await errorMessage(res, 'This breed alreay exist!');
                } else {
                    await addBreedToDb(breed);
                    res.writeHead(301, { Location: '/' });
                    res.end();
                }
            }
        });
    } else if (req.url == '/cats/add-cat' && req.method === 'GET') {
        let addCatHtml = await getHtml('addCat');
        const breedsDb = await getDbCollection('breeds');

        if (breedsDb.length) {
            const breeds = Object.values(JSON.parse(breedsDb));
            let breedsHtml = '';
            breeds.forEach(breed => breedsHtml += `<option value="${breed}">${breed}</option>`);
            addCatHtml = addCatHtml.replace('{{breeds}}', breedsHtml);
        }

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addCatHtml);
        res.end();
    }
};

module.exports = catRouter;