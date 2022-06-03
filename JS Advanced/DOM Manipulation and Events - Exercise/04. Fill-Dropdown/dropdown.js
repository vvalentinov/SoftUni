function addItem() {
    let textElement = document.getElementById('newItemText');
    let text = textElement.value;

    let valueElement = document.getElementById('newItemValue');
    let value = valueElement.value;

    let optionElement = document.createElement('option');
    optionElement.textContent = text;
    optionElement.value = value;

    let selectElement = document.getElementById('menu');
    selectElement.appendChild(optionElement);

    textElement.value = '';
    valueElement.value = '';
}