window.addEventListener('load', solve);

function solve() {
    const modelInputElement = document.getElementById('model');
    const yearInputElement = document.getElementById('year');
    const descriptionInputElement = document.getElementById('description');
    const priceInputElement = document.getElementById('price');
    const addButton = document.getElementById('add');

    const tableBodyElement = document.getElementById('furniture-list');

    let totalPriceElement = document.querySelector('.total-price');

    addButton.addEventListener('click', (e) => {
        e.preventDefault();

        const model = modelInputElement.value;
        const year = yearInputElement.value;
        const description = descriptionInputElement.value;
        const price = Number(priceInputElement.value);

        if (model == '' || description == '') {
            return;
        }

        if (year <= 0 || price <= 0) {
            return;
        }

        modelInputElement.value = '';
        yearInputElement.value = '';
        descriptionInputElement.value = '';
        priceInputElement.value = '';

        const tableRowElement = document.createElement('tr');
        tableRowElement.classList.add('info');

        const modelCellElement = document.createElement('td');
        modelCellElement.textContent = model;
        tableRowElement.appendChild(modelCellElement);

        const priceCellElement = document.createElement('td');
        priceCellElement.textContent = price.toFixed(2);
        tableRowElement.appendChild(priceCellElement);

        const actionCellElement = document.createElement('td');

        const moreInfoButton = document.createElement('button');
        moreInfoButton.classList.add('moreBtn');
        moreInfoButton.textContent = 'More Info';


        const buyButton = document.createElement('button');
        buyButton.classList.add('buyBtn');
        buyButton.textContent = 'Buy it';
        actionCellElement.appendChild(moreInfoButton);
        actionCellElement.appendChild(buyButton);
        tableRowElement.appendChild(actionCellElement);

        const hiddenTableRow = document.createElement('tr');
        hiddenTableRow.classList.add('hide');

        const yearCellElement = document.createElement('td');
        yearCellElement.textContent = `Year: ${year}`;
        hiddenTableRow.appendChild(yearCellElement);

        const descriptionCellElement = document.createElement('td');
        descriptionCellElement.setAttribute('colspan', 3);
        descriptionCellElement.textContent = `Description: ${description}`;
        hiddenTableRow.appendChild(descriptionCellElement);

        tableBodyElement.appendChild(tableRowElement);
        tableBodyElement.appendChild(hiddenTableRow);

        moreInfoButton.addEventListener('click', (e) => {
            if (e.currentTarget.textContent == 'More Info') {
                e.currentTarget.textContent = 'Less Info';
                hiddenTableRow.style.display = 'contents';
            } else {
                e.currentTarget.textContent = 'More Info';
                hiddenTableRow.style.display = 'none';
            }
        });

        buyButton.addEventListener('click', (e) => {
            tableRowElement.remove();
            hiddenTableRow.remove();

            let currentTotalPrice = Number(totalPriceElement.textContent) + price;
            totalPriceElement.textContent = currentTotalPrice.toFixed(2);
        });
    });
}
