window.addEventListener('load', solve);

function solve() {
    let addSongButton = document.getElementById('add-btn');

    let songGenreInputElement = document.getElementById('genre');
    let songNameInputElement = document.getElementById('name');
    let songAuthorInputElement = document.getElementById('author');
    let songDateInputElement = document.getElementById('date');

    function clearInputFields() {
        songGenreInputElement.value = '';
        songNameInputElement.value = '';
        songAuthorInputElement.value = '';
        songDateInputElement.value = '';
    }

    function createAndAppend(type, content, className, attribute, attributeContent, parent) {
        const element = document.createElement(type);
        if (type == 'input' || type == 'textarea' || type == 'select') {
            element.value = content;
        } else {
            element.textContent = content;
        }

        if (className != '') {
            element.classList.add(className);
        }

        if (attribute != '') {
            element.setAttribute(attribute, attributeContent);
        }

        if (parent) {
            parent.appendChild(element);
        }
        return element;
    }

    function increaseLikes(likeButton) {
        const pElement = document.querySelector('.likes p');
        const currentLikes = Number(pElement.textContent[pElement.textContent.length - 1]);
        pElement.textContent = `Total Likes: ${currentLikes + 1}`;
        likeButton.setAttribute('disabled', true);
    }

    addSongButton.addEventListener('click', (e) => {
        e.preventDefault();

        const genre = songGenreInputElement.value;
        const name = songNameInputElement.value;
        const author = songAuthorInputElement.value;
        const date = songDateInputElement.value;

        if (genre == '' || name == '' || author == '' || date == '') {
            return;
        }

        clearInputFields();

        let allHitsDivElement = document.getElementsByClassName('all-hits-container')[0];

        let hitsInfoDivElement = createAndAppend('div', '', 'hits-info', '', '', allHitsDivElement);
        createAndAppend('img', '', '', 'src', './static/img/img.png', hitsInfoDivElement);
        createAndAppend('h2', `Genre: ${genre}`, '', '', '', hitsInfoDivElement);
        createAndAppend('h2', `Name: ${name}`, '', '', '', hitsInfoDivElement);
        createAndAppend('h2', `Author: ${author}`, '', '', '', hitsInfoDivElement);
        createAndAppend('h3', `Date: ${date}`, '', '', '', hitsInfoDivElement);
        const saveSongButton = createAndAppend('button', 'Save song', 'save-btn', '', '', hitsInfoDivElement);
        const likeSongButton = createAndAppend('button', 'Like song', 'like-btn', '', '', hitsInfoDivElement);
        const deleteSongButton = createAndAppend('button', 'Delete', 'delete-btn', '', '', hitsInfoDivElement);


        likeSongButton.addEventListener('click', (e) => increaseLikes(e.currentTarget));

        saveSongButton.addEventListener('click', () => {
            const savedContainerDivElement = document.getElementsByClassName('saved-container')[0];
            hitsInfoDivElement.removeChild(saveSongButton);
            hitsInfoDivElement.removeChild(likeSongButton);
            savedContainerDivElement.appendChild(hitsInfoDivElement);
        });

        deleteSongButton.addEventListener('click', () => {
            hitsInfoDivElement.remove();
        });
    });
}