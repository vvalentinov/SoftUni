function solve(input) {
    let cars = new Map();

    input.forEach(el => {
        let [carBrand, carModel, producedCars] = el.split(' | ');
        producedCars = Number(producedCars);
        if (cars.has(carBrand) == false) {
            cars.set(carBrand, new Map());
        }
        let mapModels = cars.get(carBrand);
        if (mapModels.has(carModel) == false) {
            mapModels.set(carModel, 0);
        }
        mapModels.set(carModel, mapModels.get(carModel) + producedCars);
    });

    for (const brand of cars.keys()) {
        console.log(brand);
        let mapModels = cars.get(brand);
        for (const model of mapModels.keys()) {
            console.log(`###${model} -> ${mapModels.get(model)}`);
        }
    }
}