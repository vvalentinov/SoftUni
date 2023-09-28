const router = require('express').Router();

const animalService = require('../services/animalsService');

router.get('/', async (req, res) => {
    const animals = await animalService.getLatestThreeAnimals().lean();
    res.render('home', { animals });
});

module.exports = router;