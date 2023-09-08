function solve(input) {
    let mainSum = 0;
    let secondarySum = 0;
    input.forEach((el, index) => { mainSum += Number(el[index]); });
    input.forEach((el, index) => { secondarySum += Number(el[(el.length - 1) - index]); });
    console.log(`${mainSum} ${secondarySum}`);
}

solve(
    [[20, 40],
    [10, 60]]
);

solve(
    [[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]
);