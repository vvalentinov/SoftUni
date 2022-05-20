function solve(array, number) {
    let resultArray = [];
    for (let index = 0; index < array.length; index += number) {
        resultArray.push(array[index]);
    }
    return resultArray;
}

solve(['5', '20', '31', '4', '20'], 2);

solve(['dsa', 'asd', 'test', 'tset'], 2);

solve(['1', '2', '3', '4', '5'], 6);