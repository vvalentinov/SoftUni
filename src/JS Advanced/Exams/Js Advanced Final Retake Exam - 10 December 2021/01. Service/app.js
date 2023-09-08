window.addEventListener('load', solve);

function solve() {
    const sendFormButton = document.querySelector('#right button');
    const clearButton = document.querySelector('#completed-orders button');

    let completedOrdersSection = document.getElementById('completed-orders');

    let productTypeOptionElement = document.getElementById('type-product');
    let descriptionTextareaElement = document.getElementById('description');
    let clientNameInputElement = document.getElementById('client-name');
    let clientPhoneInputElement = document.getElementById('client-phone');

    function clearInputFields() {
        productTypeOptionElement.value = '';
        descriptionTextareaElement.value = '';
        clientNameInputElement.value = '';
        clientPhoneInputElement.value = '';
    }

    function createAndAppend(type, content, className, attribute, parent) {
        const element = document.createElement(type);
        if (type == 'input' || type == 'textarea' || type == 'select') {
            element.value = content;
        } else {
            element.textContent = content;
        }

        if (className != '') {
            element.classList.add(className);
        }

        if (attribute != '') {
            element.setAttribute(attribute, true);
        }

        if (parent) {
            parent.appendChild(element);
        }
        return element;
    }

    clearButton.addEventListener('click', (e) => {
        Array.from(completedOrdersSection.children).forEach(el => {
            if (el.className == 'container') {
                completedOrdersSection.removeChild(el);
            }
        });
    });

    function receiveOrder(productType, description, clientName, clientPhone) {
        let receivedOrdersSection = document.getElementById('received-orders');

        let divContainer = createAndAppend('div', '', 'container', '', receivedOrdersSection);
        createAndAppend('h2', `Product type for repair: ${productType}`, '', '', divContainer);
        createAndAppend('h3', `Client information: ${clientName}, ${clientPhone}`, '', '', divContainer);
        createAndAppend('h4', `Description of the problem: ${description}`, '', '', divContainer);
        let startRepairButton = createAndAppend('button', 'Start repair', 'start-btn', '', divContainer);
        let finishRepairButton = createAndAppend('button', 'Finish repair', 'finish-btn', 'disabled', divContainer);

        startRepairButton.addEventListener('click', (e) => {
            finishRepairButton.removeAttribute('disabled');
            startRepairButton.setAttribute('disabled', true);
        });

        finishRepairButton.addEventListener('click', (e) => {
            divContainer.removeChild(startRepairButton);
            divContainer.removeChild(e.currentTarget);
            completedOrdersSection.appendChild(divContainer);
        });
    }

    sendFormButton.addEventListener('click', (e) => {
        e.preventDefault();

        let productType = productTypeOptionElement.value;
        let description = descriptionTextareaElement.value;
        let clientName = clientNameInputElement.value;
        let clientPhone = clientPhoneInputElement.value;

        if (productType == '' || description == '' || clientName == '' || clientPhone == '') {
            return;
        }

        clearInputFields();

        receiveOrder(productType, description, clientName, clientPhone);
    });
}