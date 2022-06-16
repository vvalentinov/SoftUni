const expect = require('chai').expect;
const assert = require('chai').assert;
const numberOperations = require('./03. Number Operations_Resources');

describe('Number Operations Tests', () => {
    it('Pow number should work correctly', () => {
        expect(numberOperations.powNumber(4)).to.equal(16);
        expect(numberOperations.powNumber(-2)).to.equal(4);
        expect(numberOperations.powNumber(0)).to.equal(0);
    });

    describe('Number Checker Tests', () => {
        it('Should throw error if input is not a number', () => {
            expect(() => numberOperations.numberChecker(NaN)).to.throw('The input is not a number!');
            expect(() => numberOperations.numberChecker()).to.throw('The input is not a number!');
            expect(() => numberOperations.numberChecker(undefined)).to.throw('The input is not a number!');
            expect(() => numberOperations.numberChecker({})).to.throw('The input is not a number!');
        });

        it('Should return correct message if input is less than 100', () => {
            expect(numberOperations.numberChecker(99)).to.equal('The number is lower than 100!');
            expect(numberOperations.numberChecker(-99)).to.equal('The number is lower than 100!');
            expect(numberOperations.numberChecker(0)).to.equal('The number is lower than 100!');
        })

        it('Should return correct message if input is greater than or equal to 100', () => {
            expect(numberOperations.numberChecker(100)).to.equal('The number is greater or equal to 100!');
            expect(numberOperations.numberChecker(123)).to.equal('The number is greater or equal to 100!');
        });
    })

    it('Sum arrays should work correctly - first test', () => {
        assert.deepEqual(numberOperations.sumArrays([1, 2, 3, 4], [2, 15, 8]), [ 3, 17, 11, 4 ]);
    });

    it('Sum arrays should work correctly - second test', () => {
        assert.deepEqual(numberOperations.sumArrays([1, 2, 3, 4], [2, 15, 8, 9, 20, 40]), [ 3, 17, 11, 13, 20, 40 ]);
    });

    it('Sum arrays should work correctly - third test', () => {
        assert.deepEqual(numberOperations.sumArrays([1, 2, 3, 4], [5, 6, 7, -2]), [ 6, 8, 10, 2]);
    });
})