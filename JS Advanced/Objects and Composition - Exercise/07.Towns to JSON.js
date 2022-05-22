function solve(input) {
    let result = [];

    for (let index = 1; index < input.length; index++) {
        let array = input[index].split('|');
        let name = array[1].trim();
        let latitude = Number(Number(array[2].trim()).toFixed(2));
        let longitude = Number((Number(array[3].trim())).toFixed(2));

        let town = { 'Town': name, 'Latitude': latitude, 'Longitude': longitude };
        result.push(town);
    }

    console.log(JSON.stringify(result));
}

solve(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);

solve(['| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']
);