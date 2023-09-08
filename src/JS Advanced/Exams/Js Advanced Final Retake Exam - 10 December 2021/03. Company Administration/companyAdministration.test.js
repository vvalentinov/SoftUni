let expect = require('chai').expect;
const companyAdministration = require('./companyAdministration');

describe('Company Administration Tests', () => {
    describe('Hiring Employee Tests', () => {
        it('Should throw error if position is different from Programmer', () => {
            expect(() => companyAdministration.hiringEmployee('George', 'QA', 5)).to.throw('We are not looking for workers for this position.');
        });

        it('Candidate should not be approved if years of experience are less than 3', () => {
            expect(companyAdministration.hiringEmployee('George', 'Programmer', 2)).to.equal('George is not approved for this position.');
        });

        it('Candidate should be approved if years of experience are greater or equal to 3', () => {
            expect(companyAdministration.hiringEmployee('George', 'Programmer', 3)).to.equal('George was successfully hired for the position Programmer.');
            expect(companyAdministration.hiringEmployee('Mike', 'Programmer', 10)).to.equal('Mike was successfully hired for the position Programmer.');
        });
    });

    describe('Calculate Salary Tests', () => {
        const errorMessage = 'Invalid hours';
        it('Should throw error if hours argument is not of type number', () => {
            expect(() => companyAdministration.calculateSalary(undefined)).to.throw(errorMessage);
            expect(() => companyAdministration.calculateSalary(true)).to.throw(errorMessage);
            expect(() => companyAdministration.calculateSalary(null)).to.throw(errorMessage);
            expect(() => companyAdministration.calculateSalary({})).to.throw(errorMessage);
            expect(() => companyAdministration.calculateSalary('5')).to.throw(errorMessage);
            expect(() => companyAdministration.calculateSalary([170])).to.throw(errorMessage);
        });

        it('Should throw error if hours are less than zero', () => {
            expect(() => companyAdministration.calculateSalary(-12)).to.throw(errorMessage);
        });

        it('Should return correct salary if input is correct', () => {
            expect(companyAdministration.calculateSalary(60.5)).to.equal(907.5);
            expect(companyAdministration.calculateSalary(160)).to.equal(2400);
            expect(companyAdministration.calculateSalary(1)).to.equal(15);
            expect(companyAdministration.calculateSalary(3)).to.equal(45);
            expect(companyAdministration.calculateSalary(161)).to.equal(3415);
            expect(companyAdministration.calculateSalary(162)).to.equal(3430);
            expect(companyAdministration.calculateSalary(0)).to.equal(0);
        });
    });

    describe('Fired Employee Tests', () => {
        const errorMessage = 'Invalid input';
        it('Should Throw Errror When Input Is Invalid', function () {
            expect(() => companyAdministration.firedEmployee({}, 1)).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee([`Michael`, `George`, `Peter`], -1)).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee([`Michael`, `George`, `Peter`], 3)).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee([`Michael`, `George`, `Peter`], [1])).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee([], 0)).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee(`a`)).to.throw(errorMessage);
            expect(() => companyAdministration.firedEmployee(1, 1)).to.throw(errorMessage);
        });

        it('Should return correct message if input is correct', () => {
            expect(companyAdministration.firedEmployee(['George', 'Michael', 'Brad', 'Tom', 'Bill'], 3)).to.equal('George, Michael, Brad, Bill');
            expect(companyAdministration.firedEmployee(['George', 'Michael', 'Brad', 'Tom', 'Bill'], 0)).to.equal('Michael, Brad, Tom, Bill');
            expect(companyAdministration.firedEmployee(['George', 'Michael', 'Brad', 'Tom', 'Bill'], 4)).to.equal('George, Michael, Brad, Tom');
        });
    });
});