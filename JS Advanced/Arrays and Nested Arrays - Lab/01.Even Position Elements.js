function solve(input) {
    let resultArr = [];
    input.forEach((el, index) => {
        if (index % 2 == 0) {
            resultArr.push(el);
        }
    });
    console.log(resultArr.join(' '));
}

solve(['20', '30', '40', '50', '60']);
solve(['5', '10']);