function ticTacToe(input) {
    const winningCoordinates = [
        ['0 0', '0 1', '0 2'],
        ['1 0', '1 1', '1 2'],
        ['2 0', '2 1', '2 2'],
        ['0 0', '1 1', '2 2'],
        ['0 2', '1 1', '2 0'],
        ['0 0', '1 0', '2 0'],
        ['0 1', '1 1', '2 1'],
        ['0 2', '1 2', '2 2'],
    ];

    let ticTacToeGame = [
        ['false', 'false', 'false'],
        ['false', 'false', 'false'],
        ['false', 'false', 'false'],
    ];

    let currentPlayer = 'X';
    let winner = null;

    for (let index = 0; index < input.length; index++) {
        let [row, col] = input[index].split(' ').map(x => Number(x));
        if (ticTacToeGame[row][col] != 'false') {
            console.log("This place is already taken. Please choose another!");
            continue;
        }
        ticTacToeGame[row][col] = currentPlayer;
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        winner = checkForWinner();
        if (winner != null ||
            ((!ticTacToeGame[0].includes('false')) && (!ticTacToeGame[1].includes('false')) && (!ticTacToeGame[2].includes('false')))) {
            break;
        }
    }

    function checkForWinner() {
        for (let index = 0; index < winningCoordinates.length; index++) {
            const coordinatesArray = winningCoordinates[index];

            let [firstRow, firstCol] = coordinatesArray[0].split(' ').map(x => Number(x));
            let [secondRow, secondCol] = coordinatesArray[1].split(' ').map(x => Number(x));
            let [thirdRow, thirdCol] = coordinatesArray[2].split(' ').map(x => Number(x));
            if (ticTacToeGame[firstRow][firstCol] == 'X' &&
                ticTacToeGame[secondRow][secondCol] == 'X' &&
                ticTacToeGame[thirdRow][thirdCol] == 'X') {
                return 'X';
            } else if (ticTacToeGame[firstRow][firstCol] == 'O' &&
                ticTacToeGame[secondRow][secondCol] == 'O' &&
                ticTacToeGame[thirdRow][thirdCol] == 'O') {
                return 'O';
            }
        }
    }

    if (winner != null) {
        console.log(`Player ${winner} wins!`);
    } else {
        console.log("The game ended! Nobody wins :(");
    }

    ticTacToeGame.forEach(x => { console.log(`${x[0]}\t${x[1]}\t${x[2]}`) });
}

ticTacToe(["0 1", "0 0", "0 2", "2 0", "1 0", "1 1", "1 2", "2 2", "2 1", "0 0"]);
ticTacToe(["0 0", "0 0", "1 1", "0 1", "1 2", "0 2", "2 2", "1 2", "2 2", "2 1"]);
ticTacToe(["0 1", "0 0", "0 2", "2 0", "1 0", "1 2", "1 1", "2 1", "2 2", "0 0"]);