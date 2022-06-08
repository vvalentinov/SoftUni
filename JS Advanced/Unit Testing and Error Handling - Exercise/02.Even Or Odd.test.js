let expect = require('chai').expect;
const isOddOrEven = require('./02.Even or Odd');

describe('Even or Odd', () => {
    it('Should return undefined if input is not a string', () => {
        expect(isOddOrEven(0.34)).to.equal(undefined);
        expect(isOddOrEven(true)).to.equal(undefined);
        expect(isOddOrEven({})).to.equal(undefined);
        expect(isOddOrEven()).to.equal(undefined);
    });

    it('Should return even if length of input string is even', () => {
        expect(isOddOrEven('aa')).to.equal('even');
        expect(isOddOrEven('14$-+t')).to.equal('even');
        expect(isOddOrEven('[aa]')).to.equal('even');
    });

    it('Should return odd if length of input string is odd', () => {
        expect(isOddOrEven('d')).to.equal('odd');
        expect(isOddOrEven('14$-+tg')).to.equal('odd');
        expect(isOddOrEven('[aa]#+{}?')).to.equal('odd');
    });
})