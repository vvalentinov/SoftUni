function addItem() {
    let textInputElement = document.getElementById('newItemText');
    let text = textInputElement.value;
    textInputElement.value = '';

    let itemsULElement = document.getElementById('items');

    let liElement = document.createElement('li');
    liElement.textContent = text;

    itemsULElement.appendChild(liElement);
}