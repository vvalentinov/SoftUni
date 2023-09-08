function validate() {
    const usernamePattern = /^[a-zA-Z\d]{3,20}$/gm;
    const passwordPattern = /^[\w]{5,15}$/gm;
    const emailPattern = /^[^@.]+@[^@]*\.[^@]*$/;

    let companyCheckboxElement = document.getElementById('company');
    companyCheckboxElement.addEventListener('change', (e) => {
        let companyInfoFieldSetElement = document.getElementById('companyInfo');
        if (e.currentTarget.checked) {
            companyInfoFieldSetElement.style.display = "block";
        } else {
            companyInfoFieldSetElement.style.display = "none";
        }
    });

    let submitButton = document.getElementById('submit');
    submitButton.addEventListener('click', (e) => {
        e.preventDefault();
        let isValidForm = true;
        let usernameInputElement = document.getElementById('username');
        let username = usernameInputElement.value;
        if (!username.match(usernamePattern)) {
            usernameInputElement.style.borderColor = 'red';
            isValidForm = false;
        } else {
            usernameInputElement.style.borderColor = '';
        }

        let emailInputElement = document.getElementById('email');
        let email = emailInputElement.value;
        if (!email.match(emailPattern)) {
            emailInputElement.style.borderColor = 'red';
            isValidForm = false;
        } else {
            emailInputElement.style.borderColor = '';
        }

        let passwordInputElement = document.getElementById('password');
        let password = passwordInputElement.value;
        let confirmPasswordInputElement = document.getElementById('confirm-password');
        let confirmPassword = confirmPasswordInputElement.value;
        if (password.match(passwordPattern) && confirmPassword.match(passwordPattern) && password === confirmPassword) {
            passwordInputElement.style.borderColor = "";
            confirmPasswordInputElement.style.borderColor = "";
        } else {
            passwordInputElement.style.borderColor = "red";
            confirmPasswordInputElement.style.borderColor = "red";
            isValidForm = false;
        }

        if (companyCheckboxElement.checked) {
            let companyNumberInputElement = document.getElementById('companyNumber');
            let companyNumber = companyNumberInputElement.value;
            if (companyNumber < 1000 || companyNumber > 9999) {
                companyNumberInputElement.style.borderColor = 'red';
                isValidForm = false;
            } else {
                companyNumberInputElement.style.borderColor = '';
            }
        }

        let validDivElement = document.getElementById('valid');

        if (isValidForm) {
            validDivElement.style.display = "block";
        } else {
            validDivElement.style.display = "none";
        }
    });
}
