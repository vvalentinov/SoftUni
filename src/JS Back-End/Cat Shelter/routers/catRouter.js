// Third party modules
const formidable = require('formidable');

// Services
const { addBreedToDb } = require('../services/breedsService');
const { addCatToDb, editCat, removeCatWithId, findCatByName } = require('../services/catsService');

// Util Functions
const { getHtml, getDbCollection } = require('../utils/getFile');
const { errorMessage } = require('../utils/returnError');
const { validateCat } = require('../utils/validator');
const { generateEditCatHtml, generateAddCatHtml, generateShelterHtml, generateHomeHtml } = require('../utils/generateHtml');

const catRouter = async (req, res) => {
    const requestUrl = new URL(req.url, 'http://localhost:5002/');

    if (requestUrl.pathname == '/cats/add-breed' && req.method === 'GET') {
        const addBreedHtml = await getHtml('addBreed');
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addBreedHtml);
        res.end();
    } else if (requestUrl.pathname == '/cats/add-breed' && req.method === 'POST') {
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
    } else if (requestUrl.pathname == '/cats/add-cat' && req.method === 'GET') {
        const addCatHtml = await generateAddCatHtml();

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(addCatHtml);
        res.end();
    } else if (requestUrl.pathname == '/cats/add-cat' && req.method === 'POST') {
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
    } else if (requestUrl.pathname == '/cats/edit-cat' && req.method === 'GET') {
        const catId = requestUrl.searchParams.get('id');
        const editCatHtml = await generateEditCatHtml(catId);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(editCatHtml);
        res.end();
    } else if (requestUrl.pathname == '/cats/edit-cat' && req.method === 'POST') {
        const form = new formidable.IncomingForm();

        try {
            [fields, files] = await form.parse(req);

            if (!validateCat(fields)) {
                return await errorMessage(res, 'All input fields are required!');
            }

            const catId = fields['id'][0];
            const catName = fields['name'][0];
            const catDescription = fields['description'][0];
            const catImage = files['upload'][0];
            const catBreed = fields['breed'][0];

            await editCat(catId, catName, catDescription, catBreed, catImage);
        } catch (error) {
            return await errorMessage(res, `${error}`);
        }

        res.writeHead(301, { Location: '/' });
        res.end();
    } else if (requestUrl.pathname == '/cats/shelter-cat' && req.method === 'GET') {
        const catId = requestUrl.searchParams.get('id');
        const shelterHtml = await generateShelterHtml(catId);

        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(shelterHtml);
        res.end();
    } else if (requestUrl.pathname == '/cats/shelter-cat' && req.method === 'POST') {
        const catId = requestUrl.searchParams.get('id');

        await removeCatWithId(catId);

        res.writeHead(301, { Location: '/' });
        res.end();
    } else if (requestUrl.pathname == '/cats/search' && req.method === 'POST') {
        let requestData = '';
        req.on('data', async (chunk) => {
            requestData += chunk;
        });

        req.on('end', async () => {
            const input = requestData.toString().split('=')[1];
            if (input == '') {
                return await errorMessage(res, 'You must enter cat name!');
            }

            const cat = await findCatByName(input);

            if (!cat) {
                return await errorMessage(res, 'No cat found with given name!');
            }
            const homeHtml = await generateHomeHtml(cat);

            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.write(homeHtml);
            res.end();
        });
    }
};

module.exports = catRouter;