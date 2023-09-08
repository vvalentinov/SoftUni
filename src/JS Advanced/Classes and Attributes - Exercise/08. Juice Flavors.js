function solve(input) {
    let bottles = new Map();
    let juices = new Map();

    input.forEach(el => {
        let [juice, quantity] = el.split(' => ');
        quantity = Number(quantity);
        if (juices.has(juice) == false) {
            juices.set(juice, quantity);
        } else {
            juices.set(juice, juices.get(juice) + quantity);
        }

        let bottlesCount = 0;
        while (juices.get(juice) >= 1000) {
            juices.set(juice, juices.get(juice) - 1000);
            bottlesCount++;
        }

        if (bottlesCount > 0) {
            if (bottles.has(juice)) {
                bottles.set(juice, bottles.get(juice) + bottlesCount);
            } else {
                bottles.set(juice, bottlesCount);
            }
        }

    });

    for (const [key, value] of bottles) {
        if (value > 0) {
            console.log(`${key} => ${value}`);
        }
    }
}