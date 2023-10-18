const router = require('express').Router();

const { isAuthenticated } = require('../middlewares/authMiddleware');

const cryptoService = require('../services/cryptoService');

const { getErrorMessage } = require('../utils/errorHelper');

router.get('/create', isAuthenticated, (req, res) => {
    res.render('crypto/create');
});

router.post('/create', isAuthenticated, async (req, res) => {
    const cryptoOfferData = req.body;
    try {
        await cryptoService.create(cryptoOfferData);
    } catch (error) {
        res.render('crypto/create', { errorMessage: getErrorMessage(error) });
    }
});

router.get('/catalog', (req, res) => {
    res.render('crypto/catalog');
});

module.exports = router;