const fs = require('fs/promises');
const path = require('path');

exports.addBreedToDb = async (breed) => {
    const breedsDbPath = path.resolve(__dirname, '../data/breeds.json');
    const breedsDb = await fs.readFile(breedsDbPath);

    if (breedsDb.length) {
        let breeds = Object.values(JSON.parse(breedsDb));
        breeds.push(breed);
        await fs.writeFile(breedsDbPath, JSON.stringify(breeds, null, 4));
    } else {
        await fs.writeFile(breedsDbPath, JSON.stringify([breed], null, 4));
    }
};