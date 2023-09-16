const fs = require('fs/promises');
const uniqid = require('uniqid');

const { getDbCollection, getDbCollectionPath, getCatImageUploadFolderPath } = require('../utils/getFile');

exports.addCatToDb = async (catName, catDescription, catBreed, catImageFile) => {
    const cat = {
        id: uniqid(),
        name: catName,
        description: catDescription,
        breed: catBreed,
        image: catImageFile.originalFilename,
    };

    const catsCollection = await getDbCollection('cats');
    const catsCollectionPath = getDbCollectionPath('cats');

    const uploadFolder = getCatImageUploadFolderPath(catImageFile);
    await fs.rename(catImageFile.filepath, uploadFolder);

    if (catsCollection.length) {
        let cats = Object.values(JSON.parse(catsCollection));
        cats.push(cat);
        await fs.writeFile(catsCollectionPath, JSON.stringify(cats, null, 4));
    } else {
        await fs.writeFile(catsCollectionPath, JSON.stringify([cat], null, 4));
    }
};