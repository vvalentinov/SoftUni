const { getHtml, getDbCollection } = require('../utils/getFile');

exports.generateHomeHtml = async () => {
    let homeHtml = await getHtml('index', 'home');

    const catsCollection = await getDbCollection('cats');
    const cats = JSON.parse(catsCollection);

    let catsHtml = '';
    cats.forEach(cat => {
        catsHtml += `<li>
                    <img src="${cat.image}" alt="${cat.name}">
                    <h3></h3>
                    <p><span>Breed: </span>${cat.breed}</p>
                    <p><span>Description: </span>${cat.description}
                    </p>
                    <ul class="buttons">
                            <li class="btn edit"><a href="/cats/edit-cat">Change Info</a></li>
                            <li class="btn delete"><a href="/cats/shelter-cat">New Home</a></li>
                    </ul>
                </li>`;
    });

    homeHtml = homeHtml.replace('{{cats}}', catsHtml);

    return homeHtml;
};