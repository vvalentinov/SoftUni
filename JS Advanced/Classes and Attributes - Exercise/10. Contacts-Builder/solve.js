class Contact {
    constructor(firstName, lastName, phone, email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
        this.email = email;
        this._online = false;
    }

    render(id) {
        let element = document.getElementById(id);

        let articleElement = document.createElement('article');

        let titleDivElement = document.createElement('div');
        titleDivElement.classList.add('title');
        titleDivElement.textContent = `${this.firstName} ${this.lastName}`;
        if (this._online) {
            titleDivElement.classList.add('online');
        }
        this.title = titleDivElement;

        let buttonElement = document.createElement('button');
        buttonElement.innerHTML = '&#8505;';

       

        let infoDivElement = document.createElement('div');
        infoDivElement.classList.add('info');
        infoDivElement.style.display = 'none';

        let phoneSpanElement = document.createElement('span');
        phoneSpanElement.innerHTML = `&phone; ${this.phone}`;

        let emailSpanElement = document.createElement('span');
        emailSpanElement.innerHTML = `&#9993; ${this.email}`;

        buttonElement.addEventListener('click', () => {
            if (infoDivElement.style.display == 'none') {
                infoDivElement.style.display = 'block';
            } else {
                infoDivElement.style.display = 'none';
            }
        });

        titleDivElement.appendChild(buttonElement);
        infoDivElement.appendChild(phoneSpanElement);
        infoDivElement.appendChild(emailSpanElement);

        articleElement.appendChild(titleDivElement);
        articleElement.appendChild(infoDivElement);

        element.appendChild(articleElement);
    }

    set online(value) {
        this._online = value;
        if (this.title) {
            if (value === true) { 
                this.title.classList.add('online');
            } else {
                this.title.classList.remove('online');
            }
        }
    }

    get online() {
      return this._online;
    }
}