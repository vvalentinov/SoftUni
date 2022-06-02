function addItem() {
    let textInputElement = document.getElementById('newItemText');
    let text = textInputElement.value;
    textInputElement.value = '';

    let itemsULElement = document.getElementById('items');

    let liElement = document.createElement('li');
    liElement.textContent = text;

    let liDeleteButton = document.createElement('a');
    liDeleteButton.href = '#';
    liDeleteButton.textContent = '[Delete]';

    liElement.appendChild(liDeleteButton);
    itemsULElement.appendChild(liElement);

    liDeleteButton.addEventListener('click', (e) => {
        e.currentTarget.parentNode.remove();
    });
}