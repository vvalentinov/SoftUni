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

exports.getCss = async () => {
    const cssPath = path.resolve(__dirname, `../content/styles/site.css`);
    const css = await fs.readFile(cssPath);

    return css;
};

exports.getImage = async (imageName, subFolderName) => {
    let imagePath = path.resolve(__dirname, `../content/images/${imageName}`);

    if (subFolderName) {
        imagePath = path.resolve(__dirname, `../content/images/${subFolderName}/${imageName}`);
    }

    const image = await fs.readFile(imagePath);

    return image;
};