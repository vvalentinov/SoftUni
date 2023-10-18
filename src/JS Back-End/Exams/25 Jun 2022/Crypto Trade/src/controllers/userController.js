const router = require('express').Router();

const userService = require('../services/usersService');

const { getErrorMessage } = require('../utils/errorHelper');

const { JWT_KEY } = require('../constants/constants');

router.get('/register', (req, res) => {
    res.render('user/register');
});

router.post('/register', async (req, res) => {
    const userData = req.body;
    try {
        const token = await userService.register(userData);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (error) {
        res.render('user/register', { errorMessage: getErrorMessage(error) })
    }
});

router.get('/login', (req, res) => {
    res.render('user/login');
});

router.get('/logout', (req, res) => {
    res.clearCookie(JWT_KEY);
    res.redirect('/');
});

module.exports = router;