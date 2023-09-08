function solve() {
    const buttons = Array.from(document.querySelectorAll('button'));

    const quickCheckButton = buttons[0];
    const clearButton = buttons[1];

    let table = document.querySelector('table');
    const tableRows = Array.from(document.querySelectorAll('tr')).slice(2);

    let checkDivElement = document.getElementById('check');
    let paragraphElement = checkDivElement.children[0];

    quickCheckButton.addEventListener('click', (e) => {
        let values = [];
        tableRows.forEach((row, index) => {
            const rowCells = Array.from(row.cells).map(x => x.children[0].value);
            values[index] = rowCells;
        });

        let isValid = true;
        for (let index = 0; index < values.length; index++) {
            const element = values[index];
            if (element[0] == element[1] ||
                element[0] == element[2] ||
                element[1] == element[2]) {
                isValid = false;
                break;
            }
        }

        if (isValid &&
            (values[0][0] == values[1][0] ||
                values[1][0] == values[2][0] ||
                values[0][0] == values[2][0] ||
                values[0][1] == values[1][1] ||
                values[1][1] == values[2][1] ||
                values[0][1] == values[2][1] ||
                values[0][2] == values[1][2] ||
                values[1][2] == values[2][2] ||
                values[0][2] == values[2][2])) {
            isValid = false;
        }

        if (isValid) {
            table.style.border = '2px solid green';
            paragraphElement.textContent = 'You solve it! Congratulations!';
            paragraphElement.style.color = 'green';
        } else {
            table.style.border = '2px solid red';
            paragraphElement.textContent = 'NOP! You are not done yet...';
            paragraphElement.style.color = 'red';
        }
    });

    clearButton.addEventListener('click', (e) => {
        for (let index = 0; index < tableRows.length; index++) {
            const cells = Array.from(tableRows[index].cells);
            for (let i = 0; i < cells.length; i++) {
                const element = cells[i];
                element.children[0].value = '';
            }
        }
        paragraphElement.textContent = '';
        table.style.border = 'none';
    });
}