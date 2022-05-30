function generateReport() {
    let outputElement = document.getElementById('output');
    let result = [];

    let tableRows = document.getElementsByTagName('table')[0].rows;
    for (let index = 1; index <= tableRows.length - 1; index++) {
        let currentObject = {};
        const row = tableRows[index];
        let cells = Array.from(row.cells);
        for (let index = 0; index < cells.length; index++) {
            const cell = cells[index];
            let a = tableRows[0].cells[index].querySelector('input[type=checkbox]');
            if (a.checked) {
                currentObject[a.name] = cell.textContent;
            }
        }
        result.push(currentObject);
    }

    let output = JSON.stringify(result);
    outputElement.textContent = output;
}