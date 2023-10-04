const router = require('express').Router();

router.get('/register', (req, res) => {
    res.render('users/register');
});

router.post('/register', (req, res) => {
    const userData = req.body;
});

module.exports = router;