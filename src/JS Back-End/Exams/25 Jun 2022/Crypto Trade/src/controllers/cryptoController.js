const router = require('express').Router();

const { isAuthenticated } = require('../middlewares/authMiddleware');

const cryptoService = require('../services/cryptoService');

const { getErrorMessage } = require('../utils/errorHelper');

router.get('/create', isAuthenticated, (req, res) => {
    res.render('crypto/create');
});

router.post('/create', isAuthenticated, async (req, res) => {
    const owner = req.user._id;
    const cryptoOfferData = { ...req.body, owner };
    try {
        await cryptoService.create(cryptoOfferData);
        res.redirect('/crypto/catalog');
    } catch (error) {
        res.render('crypto/create', { errorMessage: getErrorMessage(error) });
    }
});

router.get('/catalog', async (req, res) => {
    const offers = await cryptoService.getAll().lean();
    res.render('crypto/catalog', { offers });
});

module.exports = router;