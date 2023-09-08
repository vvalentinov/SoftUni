class CarDealership {
    constructor(name) {
        this.name = name;
        this.availableCars = [];
        this.soldCars = [];
        this.totalIncome = 0;
    }

    addCar(model, horsepower, price, mileage) {
        if (model == '' ||
            !Number.isInteger(horsepower) ||
            horsepower < 0 ||
            price < 0 ||
            mileage < 0) {
            throw new Error('Invalid input!');
        }

        this.availableCars.push({ model, horsepower, price, mileage });

        return `New car added: ${model} - ${horsepower} HP - ${mileage.toFixed(2)} km - ${price.toFixed(2)}$`;
    }

    sellCar(model, desiredMileage) {
        let car = this.availableCars.find(c => c.model == model);
        if (car == undefined) {
            throw new Error(`${model} was not found!`);
        }

        let soldPrice = 0;
        if (car.mileage <= desiredMileage) {
            soldPrice = car.price;
        } else if (car.mileage - desiredMileage <= 40000) {
            soldPrice = car.price - car.price * 0.05;
        } else {
            soldPrice = car.price - car.price * 0.1;
        }

        this.availableCars.splice(this.availableCars.indexOf(car), 1);
        this.soldCars.push({ model, horsepower: car.horsepower, soldPrice });
        this.totalIncome += soldPrice;

        return `${model} was sold for ${soldPrice.toFixed(2)}$`;
    }

    currentCar() {
        if (this.availableCars.length == 0) {
            return 'There are no available cars';
        } else {
            let result = '-Available cars:\n';
            this.availableCars.forEach((car, index) => {
                if (index == this.availableCars.length - 1) {
                    result += `---${car.model} - ${car.horsepower} HP - ${car.mileage.toFixed(2)} km - ${car.price.toFixed(2)}$`;
                } else {
                    result += `---${car.model} - ${car.horsepower} HP - ${car.mileage.toFixed(2)} km - ${car.price.toFixed(2)}$\n`;
                }
            });
            return result;
        }
    }

    salesReport(criteria) {
        if (criteria != 'horsepower' && criteria != 'model') {
            throw new Error('Invalid criteria!');
        }

        if (criteria == 'horsepower') {
            this.soldCars = this.soldCars.sort((a, b) => b.horsepower - a.horsepower);
        } else {
            this.soldCars = this.soldCars.sort((a, b) => a.model.localeCompare(b.model));
        }

        let result = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$\n`;
        result += `-${this.soldCars.length} cars sold:\n`;
        this.soldCars.forEach((car, index) => {
            if (index == this.soldCars.length - 1) {
                result += `---${car.model} - ${car.horsepower} HP - ${car.soldPrice.toFixed(2)}$`;
            } else {
                result += `---${car.model} - ${car.horsepower} HP - ${car.soldPrice.toFixed(2)}$\n`;
            }
        });
        return result;
    }
}