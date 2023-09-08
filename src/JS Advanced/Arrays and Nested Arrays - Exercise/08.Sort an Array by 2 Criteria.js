function sortArray(input) {
    input.sort(function (a, b) {
        if (a.length < b.length) {
            return -1;
        } else if (a.length > b.length) {
            return 1;
        } else {
            if (a < b) {
                return -1;
            } else if (a > b) {
                return 1;
            }
            return 0;
        }
    });

    console.log(input.join('\n'));
}

sortArray(['alpha', 'beta', 'gamma']);
sortArray(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
sortArray(['test', 'Deny', 'omen', 'Default']);