const router = require('express').Router();

router.get('/create', (req, res) => {
    res.render('cubes/create');
});

router.post('/create', (req, res) => {
    const {
        name,
        description,
        imageUrl,
        difficultyLevel
    } = req.body;

    res.send('Creating cube...');
});

module.exports = router;