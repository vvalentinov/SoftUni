describe('Rent Car Tests', () => {
    describe('Search Car Tests', () => {
        it('Should throw error if input is invalid', () => {
            expect(() => rentCar.searchCar({}, 'BMW')).to.throw('Invalid input!');
            expect(() => rentCar.searchCar(undefined, 'BMW')).to.throw('Invalid input!');
            expect(() => rentCar.searchCar(null, 'BMW')).to.throw('Invalid input!');

            expect(() => rentCar.searchCar(['BMW'], {})).to.throw('Invalid input!');
            expect(() => rentCar.searchCar(['BMW'], undefined)).to.throw('Invalid input!');
            expect(() => rentCar.searchCar(['BMW'], null)).to.throw('Invalid input!');
            expect(() => rentCar.searchCar(['BMW'], 7)).to.throw('Invalid input!');
        });

        it('Should throw error if there are no matching elements', () => {
            expect(() => rentCar.searchCar(['BMW', 'Volkswagen', 'Audi'], 'Mercedes')).to.throw('There are no such models in the catalog!');
        });

        it('Should return correct message if there are maching elements', () => {
            expect(rentCar.searchCar(['BMW', 'Volkswagen', 'Audi', 'Audi', 'Mercedes', 'Audi'], 'Audi')).to.equal('There is 3 car of model Audi in the catalog!');
        });
    });

    describe('Calculate Price Tests', () => {
        it('Should throw error if input is invalid', () => {
            expect(() => rentCar.calculatePriceOfCar({}, 12)).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar(undefined, 12)).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar(null, 12)).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar(15, 12)).to.throw('Invalid input!');

            expect(() => rentCar.calculatePriceOfCar('Audi', {})).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar('Audi', undefined)).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar('Audi', null)).to.throw('Invalid input!');
            expect(() => rentCar.calculatePriceOfCar('Audi', '12')).to.throw('Invalid input!');
        });

        it('Should throw error if model is not present in the catalogue', () => {
            expect(() => rentCar.calculatePriceOfCar('Honda', 12)).to.throw('No such model in the catalog!');
        });

        it('Should return correct message if input is correct', () => {
            expect(rentCar.calculatePriceOfCar('Volkswagen', 12)).to.equal('You choose Volkswagen and it will cost $240!');
            expect(rentCar.calculatePriceOfCar('Audi', 12)).to.equal('You choose Audi and it will cost $432!');
            expect(rentCar.calculatePriceOfCar('Toyota', 10)).to.equal('You choose Toyota and it will cost $400!');
            expect(rentCar.calculatePriceOfCar('BMW', 10)).to.equal('You choose BMW and it will cost $450!');
            expect(rentCar.calculatePriceOfCar('Mercedes', 10)).to.equal('You choose Mercedes and it will cost $500!');
        });
    });

    describe('Check Budget Tests', () => {
        it('Should throw error if any of the input arguments are not integers', () => {
            expect(() => rentCar.checkBudget('12', 5, 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(undefined, 5, 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(null, 5, 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(false, 5, 7)).to.throw('Invalid input!');

            expect(() => rentCar.checkBudget(12, '5', 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, undefined, 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, null, 7)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, false, 7)).to.throw('Invalid input!');

            expect(() => rentCar.checkBudget(12, 5, '7')).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, 5, undefined)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, 5, null)).to.throw('Invalid input!');
            expect(() => rentCar.checkBudget(12, 5, false)).to.throw('Invalid input!');
        });

        it('Should return correct message if input is correct', () => {
            expect(rentCar.checkBudget(5, 5, 25)).to.equal('You rent a car!');
            expect(rentCar.checkBudget(7, 8, 56)).to.equal('You rent a car!');
            expect(rentCar.checkBudget(7, 7, 56)).to.equal('You rent a car!');

            expect(rentCar.checkBudget(7, 7, 18)).to.equal('You need a bigger budget!');
            expect(rentCar.checkBudget(5, 5, 24)).to.equal('You need a bigger budget!');
            expect(rentCar.checkBudget(12, 2, 20)).to.equal('You need a bigger budget!');
        });
    });
});