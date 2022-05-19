function solve(array) {
    console.log(array.reduce((previousValue, currentValue) => previousValue + currentValue, 0));
    console.log(array.reduce((previousValue, currentValue) => previousValue + (1 / currentValue), 0));
    console.log(array.join(''));
}

solve([1, 2, 3]);
solve([2, 4, 8, 16]);