function validate() {
    let emailInputElement = document.getElementById('email');

    let emailPattern = /^[a-z]+@[a-z]+.[a-z]+$/gm;

    emailInputElement.addEventListener('change', (e) => {
        if (!e.currentTarget.value.match(emailPattern)) {
            e.currentTarget.classList.add('error');
        } else {
            e.currentTarget.classList.remove('error');
        }
    });
}