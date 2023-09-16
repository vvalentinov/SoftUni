// Third party modules
const formidable = require('formidable');

// Services
const { addBreedToDb } = require('../services/breedsService');
const { addCatToDb } = require('../services/catsService');


// Util Functions
const { getHtml, getDbCollection } = require('../utils/getFile');
const { errorMessage } = require('../utils/returnError');
const { validateCat } = require('../utils/validateCatForm');

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
    } else if (req.url == '/cats/add-cat' && req.method === 'POST') {
        let form = new formidable.IncomingForm();
        let fields;
        let files;

        try {
            [fields, files] = await form.parse(req);

            if (!validateCat(fields)) {
                return await errorMessage(res, 'All input fields are required!');
            }

            const catName = fields['name'][0];
            const catDescription = fields['description'][0];
            const catBreed = fields['breed'][0];
            const catImageFile = files['upload'][0];

            await addCatToDb(catName, catDescription, catBreed, catImageFile);
        } catch (error) {
            return await errorMessage(res, `${error}`);
        }
        res.writeHead(301, { Location: '/' });
        res.end();
    }
};

module.exports = catRouter;