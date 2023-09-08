function solve(input) {
    let record = {};
    input.forEach((el) => {
        let town = el.split(' <-> ');
        let townName = town[0];
        let population = Number(town[1]);

        if (record.hasOwnProperty(townName)) {
            record[townName] += population;
        } else {
            record[townName] = population;
        }
    });

    for (const town in record) {
        console.log(`${town} : ${record[town]}`);
    }
}

solve(['Sofia <-> 1200000', 'Montana <-> 20000', 'New York <-> 10000000', 'Washington <-> 2345000', 'Las Vegas <->1000000']);

solve(['Istanbul <-> 100000', 'Honk Kong <-> 2100004', 'Jerusalem <-> 2352344', 'Mexico City <-> 23401925', 'Istanbul <-> 1000']);