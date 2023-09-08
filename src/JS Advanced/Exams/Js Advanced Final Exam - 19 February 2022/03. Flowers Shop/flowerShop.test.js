let expect = require('chai').expect;
const flowerShop = require('./flowerShop');

describe('Flower Shop Tests', () => {
    describe('Calculate Price Of Flowers Tests', () => {
        it('Should throw error if input is invalid', () => {
            expect(() => flowerShop.calcPriceOfFlowers(undefined, 12, 15)).to.throw('Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('Rose', undefined, 15)).to.throw('Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('Rose', 12, undefined)).to.throw('Invalid input!');
        });

        it('Should return correct message if input is correct', () => {
            expect(flowerShop.calcPriceOfFlowers('Rose', 2, 6)).to.equal('You need $12.00 to buy Rose!');
        });
    });

    describe('Check Flowers Available Tests', () => {
        it('Should return correct message if flower is available', () => {
            expect(flowerShop.checkFlowersAvailable('Rose', ['Lily', 'Orchid', 'Rose'])).to.equal('The Rose are available!');
        });
        it('Should return correct message if flower is sold', () => {
            expect(flowerShop.checkFlowersAvailable('Rose', ['Lily', 'Orchid', 'Carnation'])).to.equal('The Rose are sold! You need to purchase more!');
        });
    })

    describe('Sell flowers Tests', () => {
        it('Should throw error if input is not correct', () => {
            expect(() => flowerShop.sellFlowers(undefined, 12)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(['Lily', 'Orchid', 'Rose'], undefined)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(['Lily', 'Orchid', 'Rose'], -1)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(['Lily', 'Orchid', 'Rose'], 3)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(['Lily', 'Orchid', 'Rose'], 15)).to.throw('Invalid input!');
        });

        it('Should return correct message if input is correct', () => {
            expect(flowerShop.sellFlowers(['Lily', 'Orchid', 'Rose', 'Hyacinth'], 3)).to.equal('Lily / Orchid / Rose');
        });
    });
})