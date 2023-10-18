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

module.exports = router;