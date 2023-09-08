function lockedProfile() {
    let buttonsElements = Array.from(document.querySelectorAll('button'));

    buttonsElements.forEach(x => {
        x.addEventListener('click', (e) => {
            let buttonAction = e.target.textContent;

            let parentElementChildren = Array.from(e.target.parentElement.children);
            let hiddenDivElement = parentElementChildren[9];
            let radioLockElement = parentElementChildren[2];

            if (buttonAction == 'Show more') {
                if (radioLockElement.checked == false) {
                    hiddenDivElement.style.display = 'block';
                    e.target.textContent = 'Hide it';
                }
            } else {
                if (radioLockElement.checked == false) {
                    hiddenDivElement.style.display = 'none';
                    e.target.textContent = 'Show more';
                }
            }
        });
    });
}