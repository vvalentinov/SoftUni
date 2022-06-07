function solve() {
    let addButton = document.getElementById('add');

    addButton.addEventListener('click', (e) => {
        e.preventDefault();
        let taskInput = document.getElementById('task');
        let descriptionTextarea = document.getElementById('description');
        let dateInput = document.getElementById('date');

        let task = taskInput.value;
        let description = descriptionTextarea.value;
        let date = dateInput.value;

        taskInput.value = '';
        descriptionTextarea.value = '';
        dateInput.value = '';

        if (task != '' && description != '' && date != '') {
            let section = Array.from(document.querySelectorAll('section'))[1];

            let openSectionDivElement = section.children[1];

            let openSectionArticleElement = document.createElement('article');
            let h3Element = document.createElement('h3');
            h3Element.textContent = task;
            let pDescriptionElement = document.createElement('p');
            pDescriptionElement.textContent = `Description: ${description}`;
            let pDueDateElement = document.createElement('p');
            pDueDateElement.textContent = `Due Date: ${date}`;
            let articleDivElement = document.createElement('div');
            articleDivElement.classList.add('flex');
            let startButton = document.createElement('button');
            startButton.classList.add('green');
            startButton.textContent = 'Start';

            startButton.addEventListener('click', (e) => {
                let inProgressDivElement = document.getElementById('in-progress');

                let firstButton = openSectionArticleElement.children[3].children[0];
                firstButton.textContent = 'Delete';
                firstButton.classList.remove('green');
                firstButton.classList.add('red');
                firstButton.addEventListener('click', deleteEvent);

                let button = openSectionArticleElement.children[3].children[1];
                button.textContent = 'Finish';
                button.classList.remove('red');
                button.classList.add('orange');

                button.addEventListener('click', (e) => {
                    let competeSection = Array.from(document.querySelectorAll('section'))[3];
                    let competeSectionDivElement = competeSection.children[1];
                    openSectionArticleElement.children[3].remove();
                    competeSectionDivElement.appendChild(openSectionArticleElement);
                })
                inProgressDivElement.appendChild(openSectionArticleElement);
            });

            let deleteButton = document.createElement('button');
            deleteButton.classList.add('red');
            deleteButton.textContent = 'Delete';

            deleteButton.addEventListener('click', deleteEvent);

            function deleteEvent() {
                openSectionArticleElement.remove();
            }

            articleDivElement.appendChild(startButton);
            articleDivElement.appendChild(deleteButton);

            openSectionArticleElement.appendChild(h3Element);
            openSectionArticleElement.appendChild(pDescriptionElement);
            openSectionArticleElement.appendChild(pDueDateElement);
            openSectionArticleElement.appendChild(articleDivElement);

            openSectionDivElement.appendChild(openSectionArticleElement);
            section.appendChild(openSectionDivElement);
        }
    });
}