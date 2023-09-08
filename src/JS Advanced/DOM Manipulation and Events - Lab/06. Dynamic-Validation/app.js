function validate() {
    let inputElement = document.getElementById('email');

    let pattern = /[a-z]+@[a-z]+.[a-z]+/gm;

    inputElement.addEventListener('change', (e) => {
        let found = inputElement.value.match(pattern);
        if (found == null) {
            e.target.classList.add('error');
        } else {
            e.target.classList.remove('error');
        }
    });
}