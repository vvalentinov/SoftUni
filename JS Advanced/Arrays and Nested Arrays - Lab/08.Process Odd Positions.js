function solve(input) {
    const result = input.filter((el, index) => { return index % 2 != 0 }).reverse().map((el) => el * 2);
    console.log(result.join(' '));
}

solve([10, 15, 20, 25]);
solve([3, 0, 10, 4, 7, 3]);