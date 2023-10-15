const router = require('express').Router();

const userService = require('../services/usersService');
const { JWT_KEY } = require('../constants/constants');
const { getErrorMessage } = require('../utils/errorHelper')

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

module.exports = router;