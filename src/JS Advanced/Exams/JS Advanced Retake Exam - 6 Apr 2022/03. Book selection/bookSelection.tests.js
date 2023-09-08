let expect = require('chai').expect;
const bookSelection = require('./bookSelection');

describe('Book Selection Tests', () => {
    describe('Is Genre Suitable Tests', () => {
        it('Should return not suitable when age is less than or equal to 12 and genre is either Horror or Thriller', () => {
            expect(bookSelection.isGenreSuitable('Thriller', 11)).to.equal('Books with Thriller genre are not suitable for kids at 11 age');
            expect(bookSelection.isGenreSuitable('Horror', 12)).to.equal('Books with Horror genre are not suitable for kids at 12 age');
        });
        it('Should return suitable when age is bigger than 12 and genre is different from Horror and Thriller', () => {
            expect(bookSelection.isGenreSuitable('Comedy', 13)).to.equal('Those books are suitable');
            expect(bookSelection.isGenreSuitable('Comedy', -13)).to.equal('Those books are suitable');
            expect(bookSelection.isGenreSuitable('Classic', 0)).to.equal('Those books are suitable');
        });
    });
    describe('Is it affordable tests', () => {
        it('Should throw error if price or budget is not a number', () => {
            expect(() => bookSelection.isItAffordable('Comedy', 13)).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable(null, 13)).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable(undefined, 13)).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable([], 13)).to.throw('Invalid input');

            expect(() => bookSelection.isItAffordable(13, 'Comedy')).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable(13, null)).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable(13, undefined)).to.throw('Invalid input');
            expect(() => bookSelection.isItAffordable(13, [])).to.throw('Invalid input');
        });

        it('Should return correct message if budget is not enough', () => {
            expect(bookSelection.isItAffordable(15, 12)).to.equal("You don't have enough money");
        });
        it('Should return correct message if budget is enough', () => {
            expect(bookSelection.isItAffordable(12, 15)).to.equal("Book bought. You have 3$ left");
            expect(bookSelection.isItAffordable(-15, -12)).to.equal("Book bought. You have 3$ left");
            expect(bookSelection.isItAffordable(-15, 12)).to.equal("Book bought. You have 27$ left");
            expect(bookSelection.isItAffordable(15, 15)).to.equal("Book bought. You have 0$ left");
        });
    });

    describe('Suitable Titles Tests', () => {
        it('Should throw error if input is invalid', () => {
            expect(() => bookSelection.suitableTitles(null, 'Comedy')).to.throw('Invalid input');
            expect(() => bookSelection.suitableTitles(1, 'Comedy')).to.throw('Invalid input');
            expect(() => bookSelection.suitableTitles('some text', 'Comedy')).to.throw('Invalid input');

            expect(() => bookSelection.suitableTitles([], null)).to.throw('Invalid input');
            expect(() => bookSelection.suitableTitles([], 1)).to.throw('Invalid input');
            expect(() => bookSelection.suitableTitles([], {})).to.throw('Invalid input');
        });

        it('Should return correct result', () => {
            let array = [{ genre: 'Classic', title: 'To Kill a Mockingbird' }, { genre: 'Mystery', title: 'Sherlock Holmes' }, { genre: 'Classic', title: 'Little Women' }];

            expect(bookSelection.suitableTitles(array, 'Classic')[0]).to.equal('To Kill a Mockingbird');
            expect(bookSelection.suitableTitles(array, 'Classic')[1]).to.equal('Little Women');
        });
    });
});