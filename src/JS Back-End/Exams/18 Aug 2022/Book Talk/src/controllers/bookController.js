const router = require('express').Router();

const bookService = require('../services/bookService');

router.get('/all', async (req, res) => {
    const books = await bookService.getAllBooks().lean();
    res.render('books/catalog', { books });
});

module.exports = router;