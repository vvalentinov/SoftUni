let expect = require('chai').expect;
const library = require('./library');


describe('Library Tests', () => {
    describe('Calculate Price of Book Tests', () => {
        it('Should throw error if name of book is not a string', () => {
            expect(() => library.calcPriceOfBook(undefined, 12)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook(true, 12)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook({}, 12)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook([], 12)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook(2, 12)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook(null, 12)).to.throw('Invalid input');
        });

        it('Should throw error if year is not an integer', () => {
            expect(() => library.calcPriceOfBook('The Great Gatsby', undefined)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook('The Great Gatsby', true)).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook('The Great Gatsby', {})).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook('The Great Gatsby', [])).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook('The Great Gatsby', '12')).to.throw('Invalid input');
            expect(() => library.calcPriceOfBook('The Great Gatsby', null)).to.throw('Invalid input');
        });

        it('Should return correct message if year is less than or equal to 1980', () => {
            expect(library.calcPriceOfBook('The Great Gatsby', 1980)).to.equal('Price of The Great Gatsby is 10.00');
            expect(library.calcPriceOfBook('To Kill a Mockingbird', 1970)).to.equal('Price of To Kill a Mockingbird is 10.00');
        });

        it('Should return correct message if year is greater than 1980', () => {
            expect(library.calcPriceOfBook('The Great Gatsby', 2000)).to.equal('Price of The Great Gatsby is 20.00');
            expect(library.calcPriceOfBook('To Kill a Mockingbird', 1981)).to.equal('Price of To Kill a Mockingbird is 20.00');
        });
    });

    describe('Find Book Tests', () => {
        it('Should throw error if book array is empty', () => {
            expect(() => library.findBook([], 'The Great Gatsby')).to.throw('No books currently available');
        });

        it('Should return correct message if book is present in the books array', () => {
            expect(library.findBook(['To Kill a Mockingbird', 'Moby Dick', 'Jane Eyre', 'Robison Crusoe', 'The Great Gatsby'], 'The Great Gatsby')).to.equal('We found the book you want.');
        });

        it('Should return correct message if book is not present in the books array', () => {
            expect(library.findBook(['To Kill a Mockingbird', 'Moby Dick', 'Jane Eyre', 'Robison Crusoe'], 'The Great Gatsby')).to.equal('The book you are looking for is not here!');
        });
    });

    describe('Arrange Books Tests', () => {
        it('Should throw error if count books argument is not an integer', () => {
            expect(() => library.arrangeTheBooks([5])).to.throw('Invalid input');
            expect(() => library.arrangeTheBooks('4')).to.throw('Invalid input');
            expect(() => library.arrangeTheBooks(true)).to.throw('Invalid input');
            expect(() => library.arrangeTheBooks(undefined)).to.throw('Invalid input');
            expect(() => library.arrangeTheBooks(null)).to.throw('Invalid input');
            expect(() => library.arrangeTheBooks({ number: 5 })).to.throw('Invalid input');
        });

        it('Should throw error if count books argument is less than zero', () => {
            expect(() => library.arrangeTheBooks(-5)).to.throw('Invalid input');
        });

        it('Should return correct message if available space is greater than or equal to count books argument', () => {
            expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');
            expect(library.arrangeTheBooks(39)).to.equal('Great job, the books are arranged.');
        });

        it('Should return correct message if available space is less than count books argument', () => {
            expect(library.arrangeTheBooks(50)).to.equal('Insufficient space, more shelves need to be purchased.');
        });
    });
});