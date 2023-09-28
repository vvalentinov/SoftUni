const router = require('express').Router();

const userService = require('../services/usersService');

const { JWT_KEY } = require('../constants/constants');

router.get('/register', (req, res) => {
    res.render('users/register');
});

router.post('/register', async (req, res) => {
    const userData = req.body;

    try {
        const token = await userService.register(userData);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (error) {
        res.render('users/register', { error: error.message });
    }
});

module.exports = router;