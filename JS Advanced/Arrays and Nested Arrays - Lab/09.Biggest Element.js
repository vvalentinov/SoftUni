function solve(input) {
    let max = Math.max(...input[0]);
    input.forEach((el, index) => {
        if (index == 0) { return; }
        let currentMax = Math.max(...el);
        if (currentMax > max) {
            max = currentMax;
        }
    });
    console.log(max);
}

solve(
    [[20, 50, 10],
    [8, 33, 145]]
);

solve(
    [[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]
);