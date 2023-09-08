const expect = require('chai').expect;
const testNumbers = require('./testNumbers');

describe('Test Numbers Tests', () => {
    describe('Sum Numbers Tests', () => {
        it('Should return undefined if either of the arguments is not of type number', () => {
            expect(testNumbers.sumNumbers('2', 1)).to.equal(undefined);
            expect(testNumbers.sumNumbers([1], 1)).to.equal(undefined);
            expect(testNumbers.sumNumbers({ number: 1 }, 1)).to.equal(undefined);

            expect(testNumbers.sumNumbers(2, '1')).to.equal(undefined);
            expect(testNumbers.sumNumbers(1, [1])).to.equal(undefined);
            expect(testNumbers.sumNumbers(1, { number: 1 })).to.equal(undefined);

            expect(testNumbers.sumNumbers('2', '1')).to.equal(undefined);
            expect(testNumbers.sumNumbers([1, 2, 3], [1])).to.equal(undefined);
            expect(testNumbers.sumNumbers({ numberOne: 2 }, { number: 1 })).to.equal(undefined);
        });

        it('Should return correct result if arguments are of type number', () => {
            expect(testNumbers.sumNumbers(15, 10)).to.equal('25.00');
            expect(testNumbers.sumNumbers(-10, 10)).to.equal('0.00');
            expect(testNumbers.sumNumbers(-5, 10)).to.equal('5.00');
        });
    })

    describe('Number Checker Tests', () => {
        it('Should throw error if input is not of type number', () => {
            expect(() => testNumbers.numberChecker(NaN)).to.throw('The input is not a number!');
            expect(() => testNumbers.numberChecker({})).to.throw('The input is not a number!');
        });

        it('Should return correct message if input number is odd', () => {
            expect(testNumbers.numberChecker(3)).to.equal('The number is odd!');
            expect(testNumbers.numberChecker(-15)).to.equal('The number is odd!');
            expect(testNumbers.numberChecker('5')).to.equal('The number is odd!');
            expect(testNumbers.numberChecker([-9])).to.equal('The number is odd!');
        });

        it('Should return correct message if input number is even', () => {
            expect(testNumbers.numberChecker(4)).to.equal('The number is even!');
            expect(testNumbers.numberChecker(-12)).to.equal('The number is even!');
            expect(testNumbers.numberChecker('6')).to.equal('The number is even!');
            expect(testNumbers.numberChecker([8])).to.equal('The number is even!');
        });
    });

    describe('Average Sum Array Tests', () => {
        it('Should return correct result', () => {
            expect(testNumbers.averageSumArray([1, 2, 3, 4, 5])).to.equal(3);
            expect(testNumbers.averageSumArray([-1, 2, 3, -4, 5])).to.equal(1);
        });
    });
});