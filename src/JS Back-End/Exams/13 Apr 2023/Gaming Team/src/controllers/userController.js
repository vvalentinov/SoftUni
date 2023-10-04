const router = require('express').Router();

const userService = require('../services/usersService');

const { JWT_KEY } = require('../constants/constants');

const { getErrorMessage } = require('../utils/errorHelper');

router.get('/register', (req, res) => {
    res.render('users/register');
});

router.post('/register', async (req, res) => {
    const userData = req.body;

    try {
        const token = await userService.register(userData);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (err) {
        res.render('users/register', { error: getErrorMessage(err) });
    }
});

router.get('/login', (req, res) => {
    res.render('users/login');
});

module.exports = router;