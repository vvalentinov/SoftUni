function solve(input) {
    let result = [];
    let notEnoughOperands = false;
    for (let index = 0; index < input.length; index++) {
        const element = input[index];
        if (typeof element == 'number') {
            result.push(element);
        } else {
            if (result.length < 2) {
                notEnoughOperands = true;
                break;
            }
            let lastElement = result.pop();
            let previousElement = result.pop();
            switch (element) {
                case '+':
                    result.push(previousElement + lastElement);
                    break;
                case '-':
                    result.push(previousElement - lastElement);
                    break;
                case '*':
                    result.push(previousElement * lastElement);
                    break;
                case '/':
                    result.push(previousElement / lastElement);
                    break;
            }
        }
    };
    if (notEnoughOperands) {
        console.log("Error: not enough operands!");
    } else if (result.length > 1) {
        console.log("Error: too many operands!");
    } else {
        console.log(result.pop());
    }
}

solve([3, 4, '+']);
solve([5, 3, 4, '*', '-']);
solve([7, 33, 8, '-']);
solve([15, '/']);