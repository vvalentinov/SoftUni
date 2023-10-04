const router = require('express').Router();

const { getErrorMessage } = require('../utils/errorHelper');

const gameService = require('../services/gamesService');

const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/all', (req, res) => {
    res.render('games/catalog');
});

router.get('/create', (req, res) => {
    res.render('games/create');
});

router.post('/create', isAuthenticated, async (req, res) => {
    const gameData = req.body;

    try {
        await gameService.create({ ...gameData, owner: req.user._id });
        res.redirect('/games/all');
    } catch (err) {
        res.render('games/create', { error: getErrorMessage(err) });
    }
});

module.exports = router;