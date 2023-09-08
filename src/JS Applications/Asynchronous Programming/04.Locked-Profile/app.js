function lockedProfile() {
  let mainElement = document.getElementById('main');
  mainElement.innerHTML = '';

  fetch('http://localhost:3030/jsonstore/advanced/profiles')
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      for (const key in data) {
        let divElement = document.createElement('div');
        divElement.className = 'profile';

        let username = data[key].username;
        let email = data[key].email;
        let age = data[key].age;

        // Image Element
        let imgElement = document.createElement('img');
        imgElement.setAttribute('src', './iconProfile2.png');
        imgElement.className = 'userIcon';

        // Lock Radio Element
        let lockLabelElement = document.createElement('label');
        lockLabelElement.textContent = 'Lock';
        let lockInputElement = document.createElement('input');

        lockInputElement.type = 'radio';
        lockInputElement.name = 'user1Locked';
        lockInputElement.value = 'lock';
        lockInputElement.checked = true;

        // Unlock Radio Element
        let unlockLabelElement = document.createElement('label');
        unlockLabelElement.textContent = 'Unlock';
        let unlockInputElement = document.createElement('input');
        unlockInputElement.type = 'radio';
        unlockInputElement.name = 'user1Locked';
        unlockInputElement.value = 'unlock';

        lockInputElement.addEventListener('click', (e) => {
          e.currentTarget.checked = true;
          unlockInputElement.checked = false;
        });

        unlockInputElement.addEventListener('click', (e) => {
          e.currentTarget.checked = true;
          lockInputElement.checked = false;
        });

        // Hr Element
        let hrElement = document.createElement('hr');

        // Username Element
        let usernameLabel = document.createElement('label');
        usernameLabel.textContent = 'Username';
        let usernameInput = document.createElement('input');
        usernameInput.type = 'text';
        usernameInput.name = 'user1Username';
        usernameInput.value = username;
        usernameInput.disabled = true;
        usernameInput.readOnly = true;

        // User Info
        let userInfoDivElement = document.createElement('div');
        userInfoDivElement.style.display = 'none';
        userInfoDivElement.className = 'user1Username';

        let userInfoHrElement = document.createElement('hr');

        let emailLabel = document.createElement('label');
        emailLabel.textContent = 'Email:';
        let emailInput = document.createElement('input');
        emailInput.type = 'email';
        emailInput.name = 'user1Email';
        emailInput.value = email;
        emailInput.disabled = true;
        emailInput.readOnly = true;

        let ageLabel = document.createElement('label');
        ageLabel.textContent = 'Age:';
        let ageInput = document.createElement('input');
        ageInput.type = 'email';
        ageInput.name = 'user1Age';
        ageInput.value = age;
        ageInput.disabled = true;
        ageInput.readOnly = true;

        // Show More Button
        let button = document.createElement('button');
        button.textContent = 'Show more';
        button.addEventListener('click', (e) => {
          if (lockInputElement.checked == true) {
            return;
          }
          if (e.currentTarget.textContent == 'Hide it') {
            userInfoDivElement.style.display = 'none';
            e.currentTarget.textContent = 'Show more';
          } else {
            e.currentTarget.textContent = 'Hide it';
            userInfoDivElement.style.display = 'inline';
          }
        });

        // Appending elements
        divElement.appendChild(imgElement);
        divElement.appendChild(lockLabelElement);
        divElement.appendChild(lockInputElement);
        divElement.appendChild(unlockLabelElement);
        divElement.appendChild(unlockInputElement);
        divElement.appendChild(hrElement);
        divElement.appendChild(usernameLabel);
        divElement.appendChild(usernameInput);
        userInfoDivElement.appendChild(userInfoHrElement);
        userInfoDivElement.appendChild(emailLabel);
        userInfoDivElement.appendChild(emailInput);
        userInfoDivElement.appendChild(ageLabel);
        userInfoDivElement.appendChild(ageInput);
        divElement.appendChild(userInfoDivElement);
        divElement.appendChild(button);

        mainElement.appendChild(divElement);
      }
    })
    .catch((err) => {
      console.log(err);
    });
}
