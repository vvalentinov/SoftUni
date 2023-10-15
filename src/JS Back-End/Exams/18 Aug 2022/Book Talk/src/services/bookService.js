const Book = require('../models/Book');

exports.getAllBooks = () => Book.find({});

exports.createBookReview = (bookReviewData) => Book.create({ ...bookReviewData });