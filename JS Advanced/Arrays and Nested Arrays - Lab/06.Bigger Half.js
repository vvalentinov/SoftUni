function solve(input) {
    return input.sort((a, b) => { return a - b }).slice(input.length / 2);
}

solve([4, 7, 2, 5]);
solve([3, 19, 14, 7, 2, 19, 6]);