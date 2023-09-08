function solve(input) {
    let resultArray = [];
    input.forEach((el) => {
        if (el < 0) {
            resultArray.unshift(el);
        } else {
            resultArray.push(el);
        }
    });
    resultArray.forEach((el) => console.log(el));
}

solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);