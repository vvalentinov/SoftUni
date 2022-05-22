function solve(input) {
    let engine = getEngine(input.power);
    if (input.wheelsize % 2 == 0) {
        input.wheelsize = 2 * Math.floor(input.wheelsize / 2) - 1;
    }

    function getEngine(power) {
        let engine = 0;
        let volume = 0;

        let small = 90 - power;
        let normal = 120 - power;
        let monster = 200 - power;

        let differences = [small, normal, monster];
        let min = Math.min(...differences.filter(x => x >= 0));
        if (min == small) {
            engine = 90;
            volume = 1800;
        } else if (min == normal) {
            engine = 120;
            volume = 2400;
        } else if (min == monster) {
            engine = 200;
            volume = 3500;
        }

        return [engine, volume];
    };

    return {
        "model": input.model,
        "engine": {
            "power": engine[0],
            "volume": engine[1]
        },
        "carriage": {
            "type": input.carriage,
            "color": input.color
        },
        "wheels": [input.wheelsize, input.wheelsize, input.wheelsize, input.wheelsize]
    };
}

solve({ model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 });
solve({ model: 'Opel Vectra', power: 110, color: 'grey', carriage: 'coupe', wheelsize: 17 });