window.addEventListener('load', solution);

function solution() {
  const fullNameInputElement = document.getElementById('fname');
  const emailInputElement = document.getElementById('email');
  const phoneNumberInputElement = document.getElementById('phone');
  const addressInputElement = document.getElementById('address');
  const postalCodeInputElement = document.getElementById('code');

  function clearInputFields() {
    fullNameInputElement.value = '';
    emailInputElement.value = '';
    phoneNumberInputElement.value = '';
    addressInputElement.value = '';
    postalCodeInputElement.value = '';
  }

  function retrievePersonalInfo(fullName, email, phoneNumber, address, postalCode) {
    fullNameInputElement.value = fullName;
    emailInputElement.value = email;
    phoneNumberInputElement.value = phoneNumber;
    addressInputElement.value = address;
    postalCodeInputElement.value = postalCode;
  }

  const submitButton = document.getElementById('submitBTN');

  submitButton.addEventListener('click', (e) => {
    let fullName = fullNameInputElement.value;
    let email = emailInputElement.value;
    let phoneNumber = phoneNumberInputElement.value;
    let address = addressInputElement.value;
    let postalCode = postalCodeInputElement.value;

    if (fullName == '' || email == '') {
      return;
    }

    e.currentTarget.setAttribute('disabled', true);

    clearInputFields();

    let editButton = document.getElementById('editBTN');
    let continueButton = document.getElementById('continueBTN');

    editButton.removeAttribute('disabled');
    continueButton.removeAttribute('disabled');


    let infoPreviewULElement = document.getElementById('infoPreview');

    let fullNameLiElement = document.createElement('li');
    fullNameLiElement.textContent = `Full Name: ${fullName}`;

    let emailLiElement = document.createElement('li');
    emailLiElement.textContent = `Email: ${email}`;

    let phoneNumberLiElement = document.createElement('li');
    phoneNumberLiElement.textContent = `Phone Number: ${phoneNumber}`;

    let addressLiElement = document.createElement('li');
    addressLiElement.textContent = `Address: ${address}`;

    let postalCodeLiElement = document.createElement('li');
    postalCodeLiElement.textContent = `Postal Code: ${postalCode}`;

    infoPreviewULElement.appendChild(fullNameLiElement);
    infoPreviewULElement.appendChild(emailLiElement);
    infoPreviewULElement.appendChild(phoneNumberLiElement);
    infoPreviewULElement.appendChild(addressLiElement);
    infoPreviewULElement.appendChild(postalCodeLiElement);

    editButton.addEventListener('click', (e) => {
      e.currentTarget.setAttribute('disabled', true);
      continueButton.setAttribute('disabled', true);
      submitButton.removeAttribute('disabled');
      infoPreviewULElement.innerHTML = '';
      retrievePersonalInfo(fullName, email, phoneNumber, address, postalCode);
    });

    continueButton.addEventListener('click', (e) => {
      let blockDivElement = document.getElementById('block');
      blockDivElement.innerHTML = '';
      let h3MessageElement = document.createElement('h3');
      h3MessageElement.textContent = 'Thank you for your reservation!';
      blockDivElement.appendChild(h3MessageElement);
    });
  });
}
