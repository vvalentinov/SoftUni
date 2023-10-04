const router = require('express').Router();

router.get('/all', (req, res) => {
    res.render('games/catalog');
});

module.exports = router;