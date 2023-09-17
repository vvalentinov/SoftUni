const fs = require('fs/promises');
const uniqid = require('uniqid');

const {
    getImagePath,
    getDbCollection,
    getDbCollectionPath,
    getCatImageUploadFolderPath,
} = require('../utils/getFile');


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

    const uploadFolder = getCatImageUploadFolderPath(catImageFile.originalFilename);
    await fs.rename(catImageFile.filepath, uploadFolder);

    if (catsCollection.length) {
        let cats = Object.values(JSON.parse(catsCollection));
        cats.push(cat);
        await fs.writeFile(catsCollectionPath, JSON.stringify(cats, null, 4));
    } else {
        await fs.writeFile(catsCollectionPath, JSON.stringify([cat], null, 4));
    }
};

exports.editCat = async (catId, name, description, breed, imageFile) => {
    const cat = await this.getCatWithId(catId);

    const catImagePath = await getImagePath(cat.image, 'catsImages');
    await fs.unlink(catImagePath);

    const catsDb = await getDbCollection('cats');
    let cats = JSON.parse(catsDb);

    cats = cats.filter(catEl => catEl.id != cat.id);

    if (name != cat.name) {
        cat.name = name;
    }

    if (description != cat.description) {
        cat.description = description;
    }

    if (breed != cat.breed) {
        cat.breed = breed;
    }

    const uploadFolder = getCatImageUploadFolderPath(imageFile.originalFilename);
    await fs.rename(imageFile.filepath, uploadFolder);

    cat.image = imageFile.originalFilename;

    cats.push(cat);

    const catsCollectionPath = getDbCollectionPath('cats');
    await fs.writeFile(catsCollectionPath, JSON.stringify(cats, null, 4));
};

exports.getCatWithId = async (catId) => {
    const catsCollection = await getDbCollection('cats');
    const cats = JSON.parse(catsCollection);

    const cat = cats.find(catEl => catEl.id == catId);

    return cat;
};

exports.removeCatWithId = async (catId) => {
    const cat = await this.getCatWithId(catId);

    const imagePath = getCatImageUploadFolderPath(cat.image);
    await fs.unlink(imagePath);

    const catsCollection = await getDbCollection('cats');
    let cats = JSON.parse(catsCollection);

    cats = cats.filter(catEl => catEl.id != cat.id);
    const catsCollectionPath = getDbCollectionPath('cats');
    await fs.writeFile(catsCollectionPath, JSON.stringify(cats, null, 4));
};