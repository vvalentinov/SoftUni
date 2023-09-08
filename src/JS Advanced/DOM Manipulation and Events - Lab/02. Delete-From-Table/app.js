function deleteByEmail() {
    let emailInputElement = document.querySelector('input[name="email"]');
    let email = emailInputElement.value;
    emailInputElement.value = '';

    let emailTDElements = Array.from(document.querySelectorAll('tr td:nth-child(2)'));
    let resultText = '';

    for (let index = 0; index < emailTDElements.length; index++) {
        const tdElement = emailTDElements[index];
        if (tdElement.textContent == email) {
            resultText = 'Deleted.';
            tdElement.parentNode.remove();
            break;
        }
    }

    if (resultText == '') {
        resultText = 'Not found.';
    }

    let resultElement = document.getElementById('result');
    resultElement.textContent = resultText;
}