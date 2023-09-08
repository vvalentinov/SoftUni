function solve() {
  let buttonsElements = Array.from(document.querySelectorAll('button'));
  let generateButtonElement = buttonsElements[0];
  let buyButtonElement = buttonsElements[1];

  let textareasElements = Array.from(document.querySelectorAll('textarea'));

  generateButtonElement.addEventListener('click', () => {
    let inputTextareaElement = textareasElements[0];
    let inputText = inputTextareaElement.value;

    let furnitureObjects = JSON.parse(inputText);

    let tbodyElement = document.querySelector('tbody');

    furnitureObjects.forEach(x => {
      let trElement = document.createElement('tr');
      let tdImageElement = document.createElement('td');
      let imgElement = document.createElement('img');
      imgElement.src = x.img;
      tdImageElement.appendChild(imgElement);
      trElement.appendChild(tdImageElement);

      let tdNameElement = document.createElement('td');
      let paragraphNameElement = document.createElement('p');
      paragraphNameElement.textContent = x.name;
      tdNameElement.appendChild(paragraphNameElement);
      trElement.appendChild(tdNameElement);

      let tdPriceElement = document.createElement('td');
      let paragraphPriceElement = document.createElement('p');
      paragraphPriceElement.textContent = x.price;
      tdPriceElement.appendChild(paragraphPriceElement);
      trElement.appendChild(tdPriceElement);

      let tdDecFactorElement = document.createElement('td');
      let paragraphDecFactorElement = document.createElement('p');
      paragraphDecFactorElement.textContent = x.decFactor;
      tdDecFactorElement.appendChild(paragraphDecFactorElement);
      trElement.appendChild(tdDecFactorElement);

      let tdCheckboxElement = document.createElement('td');
      let checkboxInputElement = document.createElement('input');
      checkboxInputElement.setAttribute("type", "checkbox");
      tdCheckboxElement.appendChild(checkboxInputElement);
      trElement.appendChild(tdCheckboxElement);

      tbodyElement.appendChild(trElement);
    });
  });

  buyButtonElement.addEventListener('click', () => {
    let resultTextareaElement = textareasElements[1];

    let furnitureNames = [];
    let totalPrice = 0;
    let sumAvgDecFactor = 0;


    let els = Array.from(document.querySelectorAll('input[type="checkbox"]')).filter(x => x.checked);
    els.forEach(x => {
      let tdElements = Array.from(x.parentNode.parentNode.children);

      let furnitureName = tdElements[1].textContent;
      furnitureNames.push(furnitureName);

      let furniturePrice = Number(tdElements[2].textContent);
      totalPrice += furniturePrice;

      let decFactor = Number(tdElements[3].textContent);
      sumAvgDecFactor += decFactor;
    });
    let avgDecFactor = sumAvgDecFactor / els.length;

    resultTextareaElement.value = `Bought furniture: ${furnitureNames.join(', ')}\n` + `Total price: ${totalPrice.toFixed(2)}\n` + `Average decoration factor: ${avgDecFactor}`;
  });
}