function diagonalsAttack(input) {

    function getMainDiagonalSum() {
        let mainSum = 0;
        for (let index = 0; index < input.length; index++) {
            const coordinates = input[index].split(' ').map(x => Number(x));
            mainSum += coordinates[index];
        }
        return mainSum;
    };

    function getSecondaryDiagonalSum() {
        let secondarySum = 0;
        for (let index = 0; index < input.length; index++) {
            const element = input[index].split(' ').map(x => Number(x));
            secondarySum += element[(element.length - 1) - index];
        }
        return secondarySum;
    };

    let mainDiagonalSum = getMainDiagonalSum();
    let secondaryDiagonalSum = getSecondaryDiagonalSum();
    if (mainDiagonalSum == secondaryDiagonalSum) {
        let result = [];
        let mainCol = 0;
        let secondaryCol = input[0].split(' ').length - 1;
        for (let index = 0; index < input.length; index++) {
            const inputArray = input[index].split(' ').map(x => Number(x));
            let array = [];
            for (let i = 0; i < inputArray.length; i++) {
                if (mainCol == i || secondaryCol == i) {
                    array[i] = Number(input[index].split(' ').map(x => Number(x))[i]);
                } else {
                    array[i] = mainDiagonalSum;
                }

            }
            mainCol++;
            secondaryCol--;
            result.push(array);
        };
        result.forEach(x => console.log(x.join(' ')));
    } else { input.forEach(x => { console.log(x) }) }
}

diagonalsAttack(['5 3 12 3 1', '11 4 23 2 5', '101 12 3 21 10', '1 4 5 2 2', '5 22 33 11 1']);
diagonalsAttack(['1 1 1', '1 1 1', '1 1 0']);