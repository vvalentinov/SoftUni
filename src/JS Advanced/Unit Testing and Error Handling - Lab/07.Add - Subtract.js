describe('Add and Subtract', () => {
    it('Add function should work correctly', () => {
        let obj = createCalculator();
        obj.add(5);
        obj.add('8');
        expect(obj.get()).to.equal(13);
    });

    it('Subtract function should work correctly', () => {
        let obj = createCalculator();
        obj.add(10);
        obj.subtract(7);
        expect(obj.get()).to.equal(3);
    });

    it('Get function should work correctly', () => {
        let obj = createCalculator();
        obj.add(10);
        obj.add(15);
        obj.subtract(3);
        expect(obj.get()).to.equal(22);
    });

    it('Add function should return NaN if num cannot be cast to number', () => {
        let obj = createCalculator();
        expect(isNaN(obj.add(true))).to.equal(true);
        expect(isNaN(obj.add({}))).to.equal(true);
        expect(isNaN(obj.add(null))).to.equal(true);
        expect(isNaN(obj.add(undefined))).to.equal(true);
    });

    it('Subtract function should return NaN if num cannot be cast to number', () => {
        let obj = createCalculator();
        expect(isNaN(obj.subtract(true))).to.equal(true);
        expect(isNaN(obj.subtract({}))).to.equal(true);
        expect(isNaN(obj.subtract(null))).to.equal(true);
        expect(isNaN(obj.subtract(undefined))).to.equal(true);
    });
})