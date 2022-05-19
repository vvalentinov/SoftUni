function commonDivisor(firstNumber, secondNumber) {
    while (firstNumber != secondNumber) {
        if (firstNumber > secondNumber) {
            firstNumber -= secondNumber;
        } else {
            secondNumber -= firstNumber;
        }
    }
    console.log(firstNumber);
}

commonDivisor(15, 5);
commonDivisor(2154, 458);