const router = require('express').Router();

const userService = require('../services/usersService');
const { JWT_KEY } = require('../constants/constants');
const { getErrorMessage } = require('../utils/errorHelper');

router.get('/register', (req, res) => {
    res.render('users/register');
});

router.post('/register', async (req, res) => {
    const registerData = req.body;
    try {
        const token = await userService.register(registerData);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (error) {
        res.render('users/register', { errorMessage: getErrorMessage(error) });
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
    } catch (error) {
        res.render('users/login', { errorMessage: getErrorMessage(error) });
    }
});

router.get('/logout', (req, res) => {
    res.clearCookie(JWT_KEY);
    res.redirect('/');
});

module.exports = router;