const router = require('express').Router();

const userService = require('../services/usersService');
const creaturesService = require('../services/creaturesService');

const { JWT_KEY } = require('../constants/constants');

const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/login', (req, res) => {
    res.render('users/login');
});

router.post('/login', async (req, res) => {
    const userData = req.body;
    try {
        const token = await userService.login(userData.email, userData.password);
        res.cookie(JWT_KEY, token);
        res.redirect('/');
    } catch (err) {
        res.render('users/login', { errorMessage: err.message });
    }
});

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
        res.render('users/register', { errorMessage: err.message });
    }
});

router.get('/logout', (req, res) => {
    res.clearCookie(JWT_KEY);
    res.redirect('/');
});

router.get('/my-profile', isAuthenticated, async (req, res) => {
    const user = req.user;
    const creatures = await creaturesService.getUserCreatures(user._id).populate('owner').lean();
    res.render('users/my-posts', { creatures });
});

module.exports = router;