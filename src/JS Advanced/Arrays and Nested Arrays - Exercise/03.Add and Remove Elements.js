function solve(input) {
    let number = 1;
    let result = [];
    input.forEach(x => {
        if (x == 'add') {
            result.push(number);
        } else if (x == 'remove') {
            result.pop();
        }
        number++;
    });
    if (result.length == 0) {
        console.log('Empty');
    } else {
        result.forEach(x => console.log(x))
    }
}

solve(['add', 'add', 'add', 'add']);

solve(['add', 'add', 'remove', 'add', 'add']);

solve(['remove', 'remove', 'remove']);