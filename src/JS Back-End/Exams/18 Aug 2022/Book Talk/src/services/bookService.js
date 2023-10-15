const Book = require('../models/Book');

exports.getAllBooks = () => Book.find({});

exports.createBookReview = (bookReviewData, owner) => Book.create({ ...bookReviewData, owner });

exports.getBookById = (bookId) => Book.findById(bookId);

exports.wishBook = async (bookId, userId) => {
    const book = await Book.findById(bookId);
    book.wishingList.push(userId);
    await book.save();
};

exports.editBook = (bookId, bookReviewData) => Book.findByIdAndUpdate(bookId, { bookReviewData });