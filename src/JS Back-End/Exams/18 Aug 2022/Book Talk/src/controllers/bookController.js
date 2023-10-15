const router = require('express').Router();

const bookService = require('../services/bookService');
const { getErrorMessage } = require('../utils/errorHelper');
const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/all', async (req, res) => {
    const books = await bookService.getAllBooks().lean();
    res.render('books/catalog', { books });
});

router.get('/create', (req, res) => {
    res.render('books/create');
});

router.post('/create', isAuthenticated, async (req, res) => {
    const bookReviewData = req.body;
    const owner = req.user._id;
    try {
        await bookService.createBookReview(bookReviewData, owner);
        res.redirect('/book/all');
    } catch (error) {
        res.render('books/create', { errorMessage: getErrorMessage(error) });
    }
});

router.get('/details/:bookId', async (req, res) => {
    const bookId = req.params.bookId;
    const book = await bookService.getBookById(bookId).lean();
    const isOwner = req.user?._id == book.owner;
    const hasWishedBook = book.wishingList.some(x => x.toString() == req.user?._id);
    res.render('books/details', { book, isOwner, hasWishedBook });
});

router.get('/wish/:bookId', isAuthenticated, async (req, res) => {
    const bookId = req.params.bookId;
    const userId = req.user._id;
    await bookService.wishBook(bookId, userId);
    res.redirect(`/book/details/${bookId}`);
});

module.exports = router;