const router = require('express').Router();

router.get('/all', (req, res) => {
    res.render('games/catalog');
});

router.get('/create', (req, res) => {
    res.render('games/create');
});

module.exports = router;