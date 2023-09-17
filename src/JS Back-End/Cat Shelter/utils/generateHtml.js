const { getHtml, getDbCollection } = require('../utils/getFile');

const { getCatWithId } = require('../services/catsService');

exports.generateAddCatHtml = async () => {
    let addCatHtml = await getHtml('addCat');
    let breedsOptionsHtml = await generateBreedsOptionsHtml();
    addCatHtml = addCatHtml.replace('{{breeds}}', breedsOptionsHtml);
    return addCatHtml;
};

exports.generateHomeHtml = async (catInput) => {
    let homeHtml = await getHtml('index', 'home');

    const catsCollection = await getDbCollection('cats');
    const cats = JSON.parse(catsCollection);

    let catsHtml = '';
    if (catInput) {
        catsHtml = `<li>
        <img src="/${catInput.image}" alt="${catInput.name}">
        <h3></h3>
        <p><span>Breed: </span>${catInput.breed}</p>
        <p><span>Description: </span>${catInput.description}
        </p>
        <ul class="buttons">
                <li class="btn edit"><a href="/cats/edit-cat?id=${catInput.id}">Change Info</a></li>
                <li class="btn delete"><a href="/cats/shelter-cat?id=${catInput.id}">New Home</a></li>
        </ul>
    </li>`;
    } else {
        cats.forEach(cat => {
            catsHtml += `<li>
                        <img src="/${cat.image}" alt="${cat.name}">
                        <h3></h3>
                        <p><span>Breed: </span>${cat.breed}</p>
                        <p><span>Description: </span>${cat.description}
                        </p>
                        <ul class="buttons">
                                <li class="btn edit"><a href="/cats/edit-cat?id=${cat.id}">Change Info</a></li>
                                <li class="btn delete"><a href="/cats/shelter-cat?id=${cat.id}">New Home</a></li>
                        </ul>
                    </li>`;
        });
    }

    homeHtml = homeHtml.replace('{{cats}}', catsHtml);

    return homeHtml;
};

exports.generateEditCatHtml = async (catId) => {
    const cat = await getCatWithId(catId);

    const breedsHtml = await generateBreedsOptionsHtml(cat.breed);

    let editCatHtml = await getHtml('editCat');
    editCatHtml = editCatHtml.replace('{{id}}', cat.id);
    editCatHtml = editCatHtml.replace('{{name}}', cat.name);
    editCatHtml = editCatHtml.replace('{{description}}', cat.description);
    editCatHtml = editCatHtml.replace('{{breeds}}', breedsHtml);

    return editCatHtml;
};

exports.generateErrorHtml = async (errorMessage) => {
    let errorHtml = await getHtml('error');
    errorHtml = errorHtml.replace('{{error}}', `${errorMessage}`);
    return errorHtml;
};

exports.generateShelterHtml = async (catId) => {
    const cat = await getCatWithId(catId);

    let shelterHtml = await getHtml('catShelter');
    shelterHtml = shelterHtml.replace('{{id}}', cat.id);
    shelterHtml = shelterHtml.replace('{{name}}', cat.name);
    shelterHtml = shelterHtml.replace('{{image}}', cat.image);
    shelterHtml = shelterHtml.replace('{{description}}', cat.description);
    shelterHtml = shelterHtml.replaceAll('{{breed}}', cat.breed);

    return shelterHtml;
};

async function generateBreedsOptionsHtml(catBreed) {
    let result = '';
    const breedsDb = await getDbCollection('breeds');
    const breeds = JSON.parse(breedsDb);
    breeds.forEach(breed => {
        if (catBreed && breed == catBreed) {
            result += `<option value="${breed}" selected>${breed}</option>`;
        } else {
            result += `<option value="${breed}">${breed}</option>`;
        }
    });
    return result;
}