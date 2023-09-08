describe('Check for Symmetry', () => {
    it("Should return false if input is not an array", () => {
        expect(isSymmetric(2)).to.equal(false);
        expect(isSymmetric(true)).to.equal(false);
        expect(isSymmetric({})).to.equal(false);
        expect(isSymmetric(null)).to.equal(false);
    });

    it('Should return true if array is symmetric', () => {
        expect(isSymmetric([1, 2, 3, 2, 1])).to.equal(true);
        expect(isSymmetric([undefined, null, undefined])).to.equal(true);
        expect(isSymmetric([true, false, true])).to.equal(true);
        expect(isSymmetric(['1', '2', '3', '2', '1'])).to.equal(true);
        expect(isSymmetric(['1', {}, true, {}, '1'])).to.equal(true);
    });

    it('Should return false if array is not symmetric', () => {
        expect(isSymmetric([1, 2, 3, 4, 2, 1])).to.equal(false);
    });

    it('Should return false if nothing is passed', () => {
        expect(isSymmetric()).to.equal(false);
    });

    it('Should return true if there is only one element in array', () => {
        expect(isSymmetric([1])).to.equal(true);
        expect(isSymmetric([false])).to.equal(true);
        expect(isSymmetric([null])).to.equal(true);
    });
})