class LibraryCollection {
    constructor(capacity) {
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor) {
        if (this.capacity == this.books.length) {
            throw new Error('Not enough space in the collection.');
        }

        this.books.push({ bookName, bookAuthor, payed: false });
        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName) {
        let book = this.books.find(b => b.bookName == bookName);
        if (book == undefined) {
            throw new Error(`${bookName} is not in the collection.`);
        }

        if (book.payed) {
            throw new Error(`${bookName} has already been paid.`);
        }
        book.payed = true;
        return `${bookName} has been successfully paid.`;
    }

    removeBook(bookName) {
        let book = this.books.find(b => b.bookName == bookName);
        if (book == undefined) {
            throw new Error("The book, you're looking for, is not found.");
        }

        if (book.payed == false) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

        this.books.splice(this.books.indexOf(book), 1);

        return `${bookName} remove from the collection.`;
    }

    getStatistics(bookAuthor) {
        if (bookAuthor == undefined) {
            let result = `The book collection has ${this.capacity - this.books.length} empty spots left.\n`;
            this.books = this.books.sort((a, b) => a.bookName.localeCompare(b.bookName));
            this.books.forEach((book, index) => {
                let hasPaid = book.payed ? 'Has Paid' : 'Not Paid';
                if (index == this.books.length - 1) {
                    result += `${book.bookName} == ${book.bookAuthor} - ${hasPaid}.`;
                } else {
                    result += `${book.bookName} == ${book.bookAuthor} - ${hasPaid}.\n`;
                }
            });
            return result;
        } else {
            let book = this.books.find(b => b.bookAuthor == bookAuthor);
            if (book == undefined) {
                throw new Error(`${bookAuthor} is not in the collection.`);
            } else {
                let hasPaid = book.payed ? 'Has Paid' : 'Not Paid';
                return `${book.bookName} == ${bookAuthor} - ${hasPaid}.`;
            }
        }
    }
}