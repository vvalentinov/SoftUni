function extractSubset(input) {
    let currentBiggest = input[0];
    let counter = 1;
    let result = [currentBiggest]
    for (let index = 1; index <= input.length - 1; index++) {
        const number = input[index];
        if (number >= currentBiggest) {
            result[counter] = number;
            counter++;
            currentBiggest = number;
        }
    }

    return result;
}

extractSubset([1, 3, 8, 4, 10, 12, 3, 2, 24]);
extractSubset([1, 2, 3, 4]);
extractSubset([20, 3, 2, 15, 6, 1]);