const router = require('express').Router();

const cubesService = require('../services/cubesService');

router.get('/create', (req, res) => {
    res.render('cubes/create');
});

router.post('/create', async (req, res) => {
    const {
        name,
        description,
        imageUrl,
        difficultyLevel,
    } = req.body;

    await cubesService.addCube({ name, description, imageUrl, difficultyLevel });
    res.redirect('/');
});

module.exports = router;