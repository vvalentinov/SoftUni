function solve() {
    let hireWorkerButton = document.getElementById('add-worker');

    let firstNameInputElement = document.getElementById('fname');
    let lastNameInputElement = document.getElementById('lname');
    let emailInputElement = document.getElementById('email');
    let birthInputElement = document.getElementById('birth');
    let positionInputElement = document.getElementById('position');
    let salaryInputElement = document.getElementById('salary');

    let sumSpanElement = document.getElementById('sum');

    hireWorkerButton.addEventListener('click', (e) => {
        e.preventDefault();
        let firstName = firstNameInputElement.value;
        let lastName = lastNameInputElement.value;
        let email = emailInputElement.value;
        let dateOfBirth = birthInputElement.value;
        let position = positionInputElement.value;
        let salary = salaryInputElement.value;

        if (firstName == '' ||
            lastName == '' ||
            email == '' ||
            dateOfBirth == '' ||
            position == '' ||
            salary == '') {
            return;
        }

        firstNameInputElement.value = '';
        lastNameInputElement.value = '';
        emailInputElement.value = '';
        birthInputElement.value = '';
        positionInputElement.value = '';
        salaryInputElement.value = '';

        function deleteRow(row) {
            row.remove();
        }


        let tableBody = document.getElementById('tbody');

        let tableRow = document.createElement('tr');

        let firstNameTDElement = document.createElement('td');
        firstNameTDElement.textContent = firstName;

        let lastNameTDElement = document.createElement('td');
        lastNameTDElement.textContent = lastName;

        let emailTDElement = document.createElement('td');
        emailTDElement.textContent = email;

        let dateOfBirthTDElement = document.createElement('td');
        dateOfBirthTDElement.textContent = dateOfBirth;

        let positionTDElement = document.createElement('td');
        positionTDElement.textContent = position;

        let salaryTDElement = document.createElement('td');
        salaryTDElement.textContent = salary;

        let buttonsTDElement = document.createElement('td');

        let firedButton = document.createElement('button');
        firedButton.textContent = 'Fired';
        firedButton.classList.add('fired');

        firedButton.addEventListener('click', () => {
            sumSpanElement.textContent = `${(Number(sumSpanElement.textContent) - Number(salary)).toFixed(2)}`;
            deleteRow(tableRow);
        });

        let editButton = document.createElement('button');
        editButton.textContent = 'Edit';
        editButton.classList.add('edit');

        editButton.addEventListener('click', () => {
            firstNameInputElement.value = firstName;
            lastNameInputElement.value = lastName;
            emailInputElement.value = email;
            birthInputElement.value = dateOfBirth;
            positionInputElement.value = position;
            salaryInputElement.value = salary;
            sumSpanElement.textContent = `${(Number(sumSpanElement.textContent) - Number(salary)).toFixed(2)}`;
            deleteRow(tableRow);
        });

        buttonsTDElement.appendChild(firedButton);
        buttonsTDElement.appendChild(editButton);

        tableRow.appendChild(firstNameTDElement);
        tableRow.appendChild(lastNameTDElement);
        tableRow.appendChild(emailTDElement);
        tableRow.appendChild(dateOfBirthTDElement);
        tableRow.appendChild(positionTDElement);
        tableRow.appendChild(salaryTDElement);
        tableRow.appendChild(buttonsTDElement);

        tableBody.appendChild(tableRow);

        sumSpanElement.textContent = `${(Number(sumSpanElement.textContent) + Number(salary)).toFixed(2)}`;
    });
}
solve()