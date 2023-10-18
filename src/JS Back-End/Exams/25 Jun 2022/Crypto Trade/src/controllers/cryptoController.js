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

router.get('/details/:offerId', async (req, res) => {
    const userId = req.user?._id;
    const offerId = req.params.offerId;

    const offer = await cryptoService.getById(offerId).lean();
    const isAuthor = offer.owner._id == userId;
    const hasBoughtCrypto = offer.buyCripto.some(x => x._id == userId);
    res.render('crypto/details', { offer, isAuthor, hasBoughtCrypto });
});

router.get('/buyCrypto/:offerId', isAuthenticated, async (req, res) => {
    const userId = req.user._id;
    const offerId = req.params.offerId;
    await cryptoService.buyCripto(userId, offerId);
    res.redirect(`/crypto/details/${offerId}`);
});

router.get('/edit/:offerId', isAuthenticated, async (req, res) => {
    const offerId = req.params.offerId;
    const offer = await cryptoService.getById(offerId).lean();
    const selectedPaymentMethod = {
        cryptoWallet: offer.paymentMethod === 'crypto-wallet',
        creditCard: offer.paymentMethod === 'credit-card',
        debitCard: offer.paymentMethod === 'debit-card',
        paypal: offer.paymentMethod === 'paypal',
    };
    res.render('crypto/edit', { offer, selectedPaymentMethod });
});

router.post('/edit/:offerId', isAuthenticated, async (req, res) => {
    const offerId = req.params.offerId;
    const offerData = req.body;
    try {
        await cryptoService.editOffer(offerId, offerData);
        res.redirect(`/crypto/details/${offerId}`);
    } catch (error) {
        const offer = await cryptoService.getById(offerId).lean();
        res.render('crypto/edit', { offer, errorMessage: getErrorMessage(error) });
    }
});

router.get('/delete/:offerId', isAuthenticated, async (req, res) => {
    const offerId = req.params.offerId;
    await cryptoService.deleteOffer(offerId);
    res.redirect('/crypto/catalog');
});

module.exports = router;