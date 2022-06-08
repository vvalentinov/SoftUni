let expect = require('chai').expect;
const lookupChar = require('./03.Char Lookup');

describe('Char Lookup', () => {
    it('Should return undefined if string parameter is not of type string', () => {
        expect(lookupChar(8.9, 4)).to.equal(undefined);
        expect(lookupChar(true, 4)).to.equal(undefined);
        expect(lookupChar({}, 4)).to.equal(undefined);
        expect(lookupChar(undefined, 4)).to.equal(undefined);
        expect(lookupChar(null, 4)).to.equal(undefined);
    });

    it('Should return undefined if index parameter is not integer', () => {
        expect(lookupChar('test', 4.8)).to.equal(undefined);
        expect(lookupChar('test', {})).to.equal(undefined);
        expect(lookupChar('test', [])).to.equal(undefined);
        expect(lookupChar('test', null)).to.equal(undefined);
        expect(lookupChar('test', undefined)).to.equal(undefined);
    });

    it('Should return correct message if index is bigger or equal to string parameter length', () => {
        expect(lookupChar('test', 5)).to.equal('Incorrect index');
        expect(lookupChar('test', 4)).to.equal('Incorrect index');
    });

    it('Should return correct message if index is less than zero', () => {
        expect(lookupChar('test', -100)).to.equal('Incorrect index');
    });

    it('Should return correct char', () => {
        expect(lookupChar('test', 2)).to.equal('s');
        expect(lookupChar('Second Test', 0)).to.equal('S');
        expect(lookupChar('Second Test', 10)).to.equal('t');
    });
})