function sumNumbers(first, second) {
    let firstNumber = Number(first);
    let secondNumber = Number(second);
    let sum = 0;
    for (let index = firstNumber; index <= secondNumber; index++) {
        sum += index;
    }
    console.log(sum);
}

sumNumbers('1', '5');
sumNumbers('-8', '20');