const fs = require('fs/promises');
const path = require('path');

exports.getDbCollection = async (collectionName) => {
    const dbCollectionPath = this.getDbCollectionPath(collectionName);

    const dbCollection = await fs.readFile(dbCollectionPath);

    return dbCollection;
};

exports.getDbCollectionPath = (collectionName) => {
    const pathResult = path.resolve(__dirname, `../data/${collectionName}.json`);

    return pathResult;
};

exports.getCatImageUploadFolderPath = (catImageFile) => {
    const uploadFolder = path.join(__dirname, '..', 'content', 'images', 'catsImages', `${catImageFile.originalFilename}`);

    return uploadFolder;
};

exports.getHtml = async (htmlName, subFolderName) => {
    let htmlPath = path.resolve(__dirname, `../views/${htmlName}.html`);

    if (subFolderName) {
        htmlPath = path.resolve(__dirname, `../views/${subFolderName}/${htmlName}.html`);
    }

    const html = await fs.readFile(htmlPath, 'utf-8');

    return html;
};