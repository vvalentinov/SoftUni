function getFibonator() {
    let [nextNumber, previousNumber] = [1, 0];
    function fibonacci() {
        let currentNumber = nextNumber;
        nextNumber += previousNumber;
        previousNumber = nextNumber - previousNumber;
        return currentNumber;
    }

    return fibonacci;
}