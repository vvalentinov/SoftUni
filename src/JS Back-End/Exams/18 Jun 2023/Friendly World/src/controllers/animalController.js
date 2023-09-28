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

router.get('/details/:animalId', async (req, res) => {
    const animal = await animalService.getAnimalWithId(req.params.animalId).lean();

    let isCreator = false;
    let hasDonated = false;

    if (isAuthenticated) {
        isCreator = animal.owner == req.user?._id;
        hasDonated = animal.donations.some(el => el.toString() == req.user?._id);
    }

    res.render('animals/details', { animal, isCreator, hasDonated });
});

router.get('/donate/:animalId', isAuthenticated, async (req, res) => {
    const animal = await animalService.getAnimalWithId(req.params.animalId);
    const hasDonated = animal.donations.some(el => el.toString() == req.user._id);
    if (!hasDonated) {
        await animalService.donateToAnimalWithId(req.params.animalId, req.user._id);
    }
    res.redirect(`/animals/details/${req.params.animalId}`);
});

router.get('/edit/:animalId', isAuthenticated, async (req, res) => {
    const animal = await animalService.getAnimalWithId(req.params.animalId).lean();
    res.render('animals/edit', { animal });
});

router.post('/edit/:animalId', isAuthenticated, async (req, res) => {
    try {
        await animalService.editAnimal(req.params.animalId, req.body);
        res.redirect(`/animals/details/${req.params.animalId}`);
    } catch (error) {
        res.render('animals/edit', { error: error.message });
    }
});

router.get('/delete/:animalId', async (req, res) => {
    try {
        await animalService.deleteAnimal(req.params.animalId);
        res.redirect('/animals/dashboard');
    } catch (error) {
        res.redirect(`/animals/details/${animalId}`);
    }
});

router.get('/search', (req, res) => {
    res.render('animals/search');
});

router.post('/search', async (req, res) => {
    try {
        const animals = await animalService.searchAnimals(req.body.location).lean();
        res.render('animals/search', { animals });
    } catch (error) {
        res.render('animals/search', { error: error.message });
    }
});

module.exports = router;