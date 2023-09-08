function cars(input) {
    const carsObj = {};

    const commands = {
        create: (name, parentName) => {
            if (parentName != undefined) {
                carsObj[name] = Object.create(carsObj[parentName]);
            } else {
                carsObj[name] = {};
            }
        },
        set: (name, key, value) => carsObj[name][key] = value,
        print: (name) => {
            const entries = [];
            for (const key in carsObj[name]) {
                entries.push(`${key}:${carsObj[name][key]}`);
            }
            console.log(entries.join(','));
        },
    }

    input.forEach(el => {
        const elements = el.split(' ');
        switch (elements[0]) {
            case 'create':
                commands.create(elements[1], elements[3]);
                break;
            case 'set':
                commands.set(elements[1], elements[2], elements[3]);
                break;
            case 'print':
                commands.print(elements[1]);
                break;
        }
    });
}