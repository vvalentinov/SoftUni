const expect = require('chai').expect;
const StringBuilder = require('./stringBuilder');

describe('String Builder Tests', () => {
    it('Should throw error if passed argument to constructor is different than string', () => {
        expect(() => sb = new StringBuilder(12)).to.throw('Argument must be a string');
        expect(() => sb = new StringBuilder({A:'12'})).to.throw('Argument must be a string');
        expect(() => sb = new StringBuilder(true)).to.throw('Argument must be a string');
    });

    it('Should be instantiate when passing a string', () => {
        let sb = new StringBuilder('some string');
        expect(sb.toString()).to.equal('some string');
    });

    it('Should be instantiate when no argument is passed to constructor', () => {
        let sb = new StringBuilder();
        expect(sb.toString()).to.equal('');
    });

    it('Append string should throw error if passed parameter is not a string', () => {
        let sb = new StringBuilder('some string');
        expect(() => sb.append(12)).to.throw('Argument must be a string');
        expect(() => sb.append({A:'12'})).to.throw('Argument must be a string');
        expect(() => sb.append(false)).to.throw('Argument must be a string');
    });

    it('Append string should work correctly when input is correct', () => {
        let sb = new StringBuilder('some string ');
        sb.append('some string2');
        expect(sb.toString()).to.equal('some string some string2');
    });

    it('Prepend string should throw error if passed parameter is not a string', () => {
        let sb = new StringBuilder('some string');
        expect(() => sb.prepend(12)).to.throw('Argument must be a string');
        expect(() => sb.prepend({A:'12'})).to.throw('Argument must be a string');
        expect(() => sb.prepend(false)).to.throw('Argument must be a string');
    });

    it('Prepend string should work correctly when input is correct', () => {
        let sb = new StringBuilder(' some string');
        sb.prepend('some string2');
        expect(sb.toString()).to.equal('some string2 some string');
    });

    it('Insert at should throw error if passed parameter is not a string', () => {
        let sb = new StringBuilder('some string');
        expect(() => sb.insertAt(12, 0)).to.throw('Argument must be a string');
        expect(() => sb.insertAt({A:'12'}, 1)).to.throw('Argument must be a string');
        expect(() => sb.insertAt(false), 1).to.throw('Argument must be a string');
    });

    it('Insert at should work correctly when input is correct', () => {
        let sb = new StringBuilder(' some string');
        sb.insertAt('some string2', 0);
        expect(sb.toString()).to.equal('some string2 some string');
    });

    it('Remove should work correctly', () => {
        let sb = new StringBuilder(' some string');
        sb.insertAt('some string2', 0);
        sb.remove(0, 13);
        expect(sb.toString()).to.equal('some string');
    })
});