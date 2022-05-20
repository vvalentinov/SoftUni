function magicMatrices(input) {
    let sum = input[0].reduce((a, b) => a + b, 0);
    let result = true;

    for (let index = 1; index <= input.length - 1; index++) {
        let currentRowSum = input[index].reduce((a, b) => a + b, 0);
        if (currentRowSum != sum) {
            result = !result;
            break;;
        }
    }

    if (result == false) {
        return result;
    }

    for (let index = 0; index < input.length; index++) {
        let colSum = input[0][index];
        for (let i = 1; i <= input.length - 1; i++) {
            colSum += input[i][index];
        }

        if (colSum != sum) {
            result = !result;
            break;
        }
    }

    return result;
}

magicMatrices([[4, 5, 6], [6, 5, 4], [5, 5, 5]]);
magicMatrices([[11, 32, 45], [21, 0, 1], [21, 1, 1]]);
magicMatrices([[1, 0, 0], [0, 0, 1], [0, 1, 0]]);