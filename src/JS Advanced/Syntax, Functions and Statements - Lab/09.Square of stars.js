function solve(input) {
    if (input == undefined) {
        input = 5;
    }
    for (let index = 0; index < input; index++) {
        console.log(`${('* ').repeat(input).trim()}`);
    }
}

solve();
solve(1);
solve(2);
solve(5);
solve(7);