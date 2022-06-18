const expect = require('chai').expect;
const assert = require('chai').assert;
const dealership = require('./dealership');

describe('Dealership Tests', () => {
    describe('New Car Cost Tests', () => {
        it('Should return new car price if there is no discount', () => {
            expect(dealership.newCarCost('BMW', 25000)).to.equal(25000);
        });

        it('Should return price with discount when returning old car', () => {
            expect(dealership.newCarCost('Audi A4 B8', 20000)).to.equal(5000);
        });
    });

    describe('Car Equipment Tests', () => {
        it('Should return correct extras - first test', () => {
            assert.deepEqual(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], [1, 2]), ['sliding roof', 'sport rims' ]);
        });

        it('Should return correct extras - second test', () => {
            assert.deepEqual(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], [0, 3]), ['heated seats', 'navigation' ]);
        });

        it('Should return correct extras - third test', () => {
            assert.deepEqual(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], [0]), ['heated seats' ]);
        });

        it('Should return correct extras - fourth test', () => {
            assert.deepEqual(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], [3]), ['navigation' ]);
        });
    });

    describe('Euro Category Tests', () => {
        it('Should return correct message if euro category is less than 4', () => {
            expect(dealership.euroCategory(3)).to.equal('Your euro category is low, so there is no discount from the final price!');
            expect(dealership.euroCategory(0)).to.equal('Your euro category is low, so there is no discount from the final price!');
            expect(dealership.euroCategory(-2)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });

        it('Should return correct message if euro category is greater than or equal to 4', () => {
            expect(dealership.euroCategory(4)).to.equal('We have added 5% discount to the final price: 14250.');
            expect(dealership.euroCategory(20)).to.equal('We have added 5% discount to the final price: 14250.');
        });
    });
});