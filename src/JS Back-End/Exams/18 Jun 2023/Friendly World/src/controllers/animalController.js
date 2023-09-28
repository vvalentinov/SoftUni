const router = require('express').Router();

const animalService = require('../services/animalsService');

const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/add-animal', isAuthenticated, (req, res) => {
    res.render('animals/create');
});

router.post('/add-animal', isAuthenticated, async (req, res) => {
    const animalData = { ...req.body, owner: req.user._id };
    try {
        await animalService.add(animalData);
        res.redirect('/animals/dashboard');
    } catch (error) {
        res.render('animals/create', { error: error.message });
    }
});

router.get('/dashboard', async (req, res) => {
    const animals = await animalService.getAll().lean();
    res.render('animals/dashboard', { animals });
});

module.exports = router;