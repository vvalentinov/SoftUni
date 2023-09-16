const fs = require('fs/promises');
const path = require('path');

exports.getDbCollection = async (collectionName) => {
    const dbCollectionPath = path.resolve(__dirname, `../data/${collectionName}.json`);
    const dbCollection = await fs.readFile(dbCollectionPath);

    return dbCollection;
};

exports.getHtml = async (htmlName, subFolderName) => {
    let htmlPath = path.resolve(__dirname, `../views/${htmlName}.html`);

    if (subFolderName) {
        htmlPath = path.resolve(__dirname, `../views/${subFolderName}/${htmlName}.html`);
    }

    const html = await fs.readFile(htmlPath, 'utf-8');
    return html;
};