function solve(townName, population, treasury) {
    return {
        name: townName,
        population,
        treasury,
        taxRate: 10,
        collectTaxes() {
            this.treasury = Math.floor(this.treasury + this.population * this.taxRate);
        },
        applyGrowth(percentage) {
            percentage /= 100;
            this.population = Math.floor(this.population * (percentage + 1));
        },
        applyRecession(percentage) {
            percentage /= 100;
            this.treasury = Math.floor((this.treasury * (1 - percentage)));
        }
    };
}

const city1 = cityTaxes('Tortuga', 7000, 15000);
console.log(city1);

const city2 = cityTaxes('Tortuga', 7000, 15000);
city2.collectTaxes();
console.log(city2.treasury);
city2.applyGrowth(5);
console.log(city2.population);

