function solve() {
    let inputArguments = Array.from(arguments);
    let obj = {};
    inputArguments.forEach(x => {
        let type = typeof (x);
        console.log(`${type}: ${x}`);
        if (obj[type]) {
            obj[type]++;;
        } else {
            obj[type] = 1;
        }
    });

    Object.keys(obj)
        .sort((a, b) => obj[b] - obj[a])
        .forEach(x => console.log(`${x} = ${obj[x]}`));
}