function solve(input) {
    let record = {};
    for (let index = 0; index < input.length; index++) {
        if (index % 2 == 0) {
            record[`${input[index]}`] = Number(input[index + 1]);
        }
    }

    console.log(record);
}

solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);