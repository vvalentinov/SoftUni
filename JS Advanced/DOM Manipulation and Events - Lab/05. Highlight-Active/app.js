function focused() {
    let inputElements = Array.from(document.querySelectorAll('input[type="text"]'));


    inputElements.forEach(x =>
        x.addEventListener('focus', (e) => {
            let parentElement = e.target.parentElement;
            parentElement.classList.add('focused');
        },
            x.addEventListener('blur', (e) => {
                e.target.parentElement.classList.remove('focused');
            })
        )
    );
}