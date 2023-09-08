function solve(inputMatrix) {
    let numberOfPairs = 0;
    inputMatrix.forEach((array, index) => {
        array.forEach((el, idx) => {
            if (idx + 1 < array.length && array[idx] === array[idx + 1]) { numberOfPairs++; }
            if (index + 1 < inputMatrix.length && inputMatrix[index + 1][idx] === el) { numberOfPairs++; }
        });
    });
    console.log(numberOfPairs);
}

solve(
    [['2', '3', '4', '7', '0'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']]
);

solve(
    [['test', 'yes', 'yo', 'ho'],
    ['well', 'done', 'yo', '6'],
    ['not', 'done', 'yet', '5']]
);