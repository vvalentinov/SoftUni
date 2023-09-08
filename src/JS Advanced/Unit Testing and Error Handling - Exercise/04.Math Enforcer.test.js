let expect = require('chai').expect;
const mathEnforcer = require('./04.Math Enforcer');

describe('Math Enforcer', () => {
    describe('Add Five Function', () => {
        it('Should return undefined if paramater is not a number', () => {
            expect(mathEnforcer.addFive('num')).to.equal(undefined);
            expect(mathEnforcer.addFive([])).to.equal(undefined);
            expect(mathEnforcer.addFive()).to.equal(undefined);
            expect(mathEnforcer.addFive(true)).to.equal(undefined);
            expect(mathEnforcer.addFive(null)).to.equal(undefined);
            expect(mathEnforcer.addFive(undefined)).to.equal(undefined);
        });

        it('Should return correct result', () => {
            expect(mathEnforcer.addFive(5)).to.equal(10);
            expect(mathEnforcer.addFive(-10)).to.equal(-5);
            expect(mathEnforcer.addFive(0.34)).to.be.closeTo(5.34, 0.01);
        });
    });

    describe('Subtract Ten Function', () => {
        it('Should return undefined if paramater is not a number', () => {
            expect(mathEnforcer.subtractTen('num')).to.equal(undefined);
            expect(mathEnforcer.subtractTen([])).to.equal(undefined);
            expect(mathEnforcer.subtractTen()).to.equal(undefined);
            expect(mathEnforcer.subtractTen(true)).to.equal(undefined);
            expect(mathEnforcer.subtractTen(null)).to.equal(undefined);
            expect(mathEnforcer.subtractTen(undefined)).to.equal(undefined);
        });

        it('Should return correct result', () => {
            expect(mathEnforcer.subtractTen(5)).to.equal(-5);
            expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
            expect(mathEnforcer.subtractTen(0.34)).to.be.closeTo(-9.66, 0.01);
        });
    });

    describe('Sum Function', () => {
        it('Should return undefined if one of the parameters is not a number', () => {
            expect(mathEnforcer.sum('num', 9)).to.equal(undefined);
            expect(mathEnforcer.sum(-100, true)).to.equal(undefined);
        });

        it('Should return correct result', () => {
            expect(mathEnforcer.sum(5, 8)).to.equal(13);
            expect(mathEnforcer.sum(-10, 10)).to.equal(0);
            expect(mathEnforcer.sum(0.34, 7.056)).to.be.closeTo(7.396, 0.01);
        });
    });
})