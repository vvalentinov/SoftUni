describe('RGB to Hex', () => {
    // Red value tests
    it('Should return undefined if red value is not an integer', () => {
        expect(rgbToHexColor(0.34, 45, 67)).to.equal(undefined);
        expect(rgbToHexColor({}, 45, 67)).to.equal(undefined);
        expect(rgbToHexColor(true, 45, 67)).to.equal(undefined);
        expect(rgbToHexColor(undefined, 45, 67)).to.equal(undefined);
        expect(rgbToHexColor(null, 45, 67)).to.equal(undefined);
    });
    it('Should return undefined if red value is less than zero', () => {
        expect(rgbToHexColor(-100, 45, 67)).to.equal(undefined);
    });
    it('Should return undefined if red value is larger than 255', () => {
        expect(rgbToHexColor(256, 45, 67)).to.equal(undefined);
    });

    //Green value tests
    it('Should return undefined if green value is not an integer', () => {
        expect(rgbToHexColor(65, 0.45, 67)).to.equal(undefined);
        expect(rgbToHexColor(100, {}, 67)).to.equal(undefined);
        expect(rgbToHexColor(8, false, 67)).to.equal(undefined);
        expect(rgbToHexColor(55, undefined, 67)).to.equal(undefined);
        expect(rgbToHexColor(90, null, 67)).to.equal(undefined);
    });
    it('Should return undefined if green value is less than zero', () => {
        expect(rgbToHexColor(100, -100, 67)).to.equal(undefined);
    });
    it('Should return undefined if green value is larger than 255', () => {
        expect(rgbToHexColor(255, 256, 67)).to.equal(undefined);
    });

    //Blue value tests
    it('Should return undefined if blue value is not an integer', () => {
        expect(rgbToHexColor(65, 45, 0.67)).to.equal(undefined);
        expect(rgbToHexColor(100, 35, {})).to.equal(undefined);
        expect(rgbToHexColor(8, 15, false)).to.equal(undefined);
        expect(rgbToHexColor(55, 45, undefined)).to.equal(undefined);
        expect(rgbToHexColor(90, 17, null)).to.equal(undefined);
    });
    it('Should return undefined if blue value is less than zero', () => {
        expect(rgbToHexColor(100, 100, -67)).to.equal(undefined);
    });
    it('Should return undefined if blue value is larger than 255', () => {
        expect(rgbToHexColor(255, 255, 256)).to.equal(undefined);
    });

    it('Should return correct value', () => {
        expect(rgbToHexColor(17, 8, 55)).to.equal('#110837');
        expect(rgbToHexColor(0, 0, 0)).to.equal('#000000');
        expect(rgbToHexColor(255, 255, 255)).to.equal('#FFFFFF');
    });
})