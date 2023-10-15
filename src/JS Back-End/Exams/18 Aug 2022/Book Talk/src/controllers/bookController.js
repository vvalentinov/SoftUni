const router = require('express').Router();

const bookService = require('../services/bookService');
const { getErrorMessage } = require('../utils/errorHelper');

router.get('/all', async (req, res) => {
    const books = await bookService.getAllBooks().lean();
    res.render('books/catalog', { books });
});

router.get('/create', (req, res) => {
    res.render('books/create');
});

router.post('/create', async (req, res) => {
    const bookReviewData = req.body;
    try {
        await bookService.createBookReview(bookReviewData);
        res.redirect('/book/all');
    } catch (error) {
        res.render('books/create', { errorMessage: getErrorMessage(error) });
    }
});

module.exports = router;