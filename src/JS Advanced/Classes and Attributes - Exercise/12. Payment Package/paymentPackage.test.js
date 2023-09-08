const expect = require('chai').expect;
const PaymentPackage = require('./paymentPackage');

describe('Payment Package Class Tests', () => {
    it('Should throw error if name property is not a string', () => {
        expect(() => pp = new PaymentPackage(12, 12)).to.throw('Name must be a non-empty string');
    });

    it('Should throw error if name property is empty string', () => {
        expect(() => pp = new PaymentPackage('', 12)).to.throw('Name must be a non-empty string');
    });

    it('Should set name property if it is correct', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(pp.name).to.equal('Shipping');
    });

    it('Should throw error if value parameter is not of type number', () => {
        expect(() => pp = new PaymentPackage('Shipping', '12')).to.throw('Value must be a non-negative number');
    });

    it('Should throw error if value parameter is less than zero', () => {
        expect(() => pp = new PaymentPackage('Shipping', -12)).to.throw('Value must be a non-negative number');
    });

    it('Should set value property if it is correct', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(pp.value).to.equal(12);
        pp.value = 0;
        expect(pp.value).to.equal(0);
    });

    it('Should have VAT equal to 20 after initialization', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(pp.VAT).to.equal(20);
    });

    it('Should throw error if VAT input is not of type number', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(() => pp.VAT = '12').to.throw('VAT must be a non-negative number');
    });

    it('Should throw error if VAT input is less than zero', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(() => pp.VAT = -12).to.throw('VAT must be a non-negative number');
    });

    it('Should return correct VAT', () => {
        let pp = new PaymentPackage('Shipping', 12);
        pp.VAT = 50;
        expect(pp.VAT).to.equal(50);
        pp.VAT = 0;
        expect(pp.VAT).to.equal(0);
    });

    it('Should have active equal to true after initialization', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(pp.active).to.equal(true);
    });

    it('Should throw error if active parameter is not of type bool', () => {
        let pp = new PaymentPackage('Shipping', 12);
        expect(() => pp.active = 'true').to.throw('Active status must be a boolean');
        expect(() => pp.active = 2).to.throw('Active status must be a boolean');
    });

    it('Should return correct active', () => {
        let pp = new PaymentPackage('Shipping', 12);
        pp.active = false;
        expect(pp.active).to.equal(false);
    });

    it('Should return correct result when call toString if active is false', () => {
        let pp = new PaymentPackage('Shipping', 12);
        pp.active = false;
        pp.VAT = 45;
        let result = 'Package: Shipping (inactive)\n- Value (excl. VAT): 12\n- Value (VAT 45%): 17.4';
        expect(pp.toString()).to.equal(result);
    });
});