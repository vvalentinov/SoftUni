describe('Sum of Numbers', () => {
    it("Should return correct sum", () => {
        expect(sum([1, 2, 3, 4])).to.equal(10);
    });

    it('Sum must be zero when the array is empty', () => {
        expect(sum([])).to.equal(0);
    });

    it('Should work correctly if it is an array of strings', () => {
        expect(sum(['2', '5', '8'])).to.equal(15);
    });
})