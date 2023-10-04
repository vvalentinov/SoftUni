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

router.post('/login', async (req, res) => {
    const { email, password } = req.body;

    try {
        const token = await userService.login(email, password);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (err) {
        res.render('users/login', { error: getErrorMessage(err) });
    }
});

router.get('/logout', (req, res) => {
    res.clearCookie(JWT_KEY);
    res.redirect('/');
})

module.exports = router;