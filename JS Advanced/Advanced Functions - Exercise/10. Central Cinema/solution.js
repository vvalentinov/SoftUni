function solve() {
    let formElement = document.getElementById("add-new");
    formElement.addEventListener('submit', (e) => {
        e.preventDefault();
    });

    let movieNameElement = formElement.elements[0];
    let hallElement = formElement.elements[1];
    let ticketPriceElement = formElement.elements[2];
    let onScreenButton = formElement.elements[3];

    onScreenButton.addEventListener('click', () => {
        let movieName = movieNameElement.value;
        let movieHall = hallElement.value;
        let ticketPrice = parseInt(ticketPriceElement.value).toFixed(2);
        if (movieName && movieHall && ticketPrice && isNaN(ticketPrice) == false) {
            movieNameElement.value = '';
            hallElement.value = '';
            ticketPriceElement.value = '';

            let archiveSectionElement = document.getElementById('archive');

            let moviesUlElement = document.querySelector('#movies ul');

            let movieLiElement = document.createElement('li');

            let spanElement = document.createElement('span');
            spanElement.textContent = movieName;
            movieLiElement.appendChild(spanElement);

            let movieHallStrongElement = document.createElement('strong');
            movieHallStrongElement.textContent = `Hall: ${movieHall}`;
            movieLiElement.appendChild(movieHallStrongElement);

            let divElement = document.createElement('div');

            let ticketPriceStrongElement = document.createElement('strong');
            ticketPriceStrongElement.textContent = `${ticketPrice}`;
            divElement.appendChild(ticketPriceStrongElement);

            let ticketsSoldInputElement = document.createElement('input');
            ticketsSoldInputElement.placeholder = 'Tickets Sold';
            divElement.appendChild(ticketsSoldInputElement);

            let archiveButton = document.createElement('button');
            archiveButton.textContent = 'Archive';
            divElement.appendChild(archiveButton);

            movieLiElement.appendChild(divElement);

            moviesUlElement.appendChild(movieLiElement);

            archiveButton.addEventListener('click', () => {
                if (isNaN(parseInt(ticketsSoldInputElement.value)) == false) {
                    let numberOfTickets = Number(ticketsSoldInputElement.value);
                    moviesUlElement.removeChild(movieLiElement);

                    let archiveUlElement = archiveSectionElement.getElementsByTagName('ul')[0];

                    let archiveMovieLiElement = document.createElement('li');

                    let archiveSpanElement = document.createElement('span');
                    archiveSpanElement.textContent = movieName;
                    archiveMovieLiElement.appendChild(archiveSpanElement);

                    let archiveMovieHallStrongElement = document.createElement('strong');
                    archiveMovieHallStrongElement.textContent = `Total amount: ${(numberOfTickets * ticketPrice).toFixed(2)}`;
                    archiveMovieLiElement.appendChild(archiveMovieHallStrongElement);

                    let archiveDeleteButton = document.createElement('button');
                    archiveDeleteButton.textContent = 'Delete';
                    archiveMovieLiElement.appendChild(archiveDeleteButton);

                    archiveUlElement.appendChild(archiveMovieLiElement);


                    archiveDeleteButton.addEventListener('click', () => {
                        archiveUlElement.removeChild(archiveMovieLiElement);
                    });
                }
            });

            let archiveSectionButtons = Array.from(document.querySelectorAll('#archive button'));
            let clearButton = archiveSectionButtons[archiveSectionButtons.length - 1];
            clearButton.addEventListener('click', () => {
                let archiveUlElement = archiveSectionElement.getElementsByTagName('ul')[0];
                while (archiveUlElement.firstChild) {
                    archiveUlElement.removeChild(archiveUlElement.lastChild);
                }
            });
        }
    });
}