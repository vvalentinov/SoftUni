const Book = require('../models/Book');

exports.getAllBooks = () => Book.find({});