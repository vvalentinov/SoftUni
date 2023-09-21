const router = require('express').Router();

router.get('/create', (req, res) => {
    res.render('cubes/create');
});

module.exports = router;