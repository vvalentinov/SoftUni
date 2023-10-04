const router = require('express').Router();

const { getErrorMessage } = require('../utils/errorHelper');

const gameService = require('../services/gamesService');

const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/all', async (req, res) => {
    const games = await gameService.getAll().lean();
    res.render('games/catalog', { games });
});

router.get('/create', isAuthenticated, (req, res) => {
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

router.get('/details/:gameId', async (req, res) => {
    const game = await gameService.getGameWithId(req.params.gameId).lean();
    const isOwner = req.user?._id == game.owner;
    const hasBoughtTheGame = game.boughtBy.some(x => x.toString() == req.user?._id);
    res.render('games/details', { game, isOwner, hasBoughtTheGame });
});

router.get('/buy/:gameId', async (req, res) => {
    await gameService.buyGame(req.params.gameId, req.user._id);
    res.redirect(`/games/details/${req.params.gameId}`);
});

router.get('/edit/:gameId', isAuthenticated, async (req, res) => {
    const game = await gameService.getGameWithId(req.params.gameId).lean();
    res.render('games/edit', { game });
});

router.post('/edit/:gameId', isAuthenticated, async (req, res) => {
    const gameData = req.body;
    await gameService.editGame(req.params.gameId, gameData);
    res.redirect(`/games/details/${req.params.gameId}`);
});

module.exports = router;