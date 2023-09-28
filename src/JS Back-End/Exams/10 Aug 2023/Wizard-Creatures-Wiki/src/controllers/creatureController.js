const router = require('express').Router();

const creaturesService = require('../services/creaturesService');

const { isAuthenticated } = require('../middlewares/authMiddleware');

router.get('/create', isAuthenticated, (req, res) => {
    res.render('creatures/create');
});

router.post('/create', isAuthenticated, async (req, res) => {
    const creatureData = { ...req.body, owner: req.user._id };
    try {
        await creaturesService.addCreature(creatureData);
        res.redirect('/creatures/all');
    } catch (err) {
        res.render('creatures/create', { errorMessage: err.message });
    }
});

router.get('/all', async (req, res) => {
    const creatures = await creaturesService.getAllCreatures().lean();
    res.render('creatures/all-posts', { creatures });
});

router.get('/details/:creatureId', async (req, res) => {
    const creatureId = req.params.creatureId;
    const creature = await creaturesService.getCreatureWithId(creatureId).lean();

    const userId = req.user?._id;
    const isAuthor = userId == creature.owner._id;
    const hasVoted = Boolean(creature.votes.find(vote => vote._id == userId));

    const usersVotes = (await creaturesService.getCreatureUsersVotes(creatureId)).join(', ');
    const votesCount = creature.votes.length;

    res.render('creatures/details', { creature, isAuthor, hasVoted, votesCount, usersVotes });
});

router.get('/vote/:creatureId', isAuthenticated, async (req, res) => {
    const creatureId = req.params.creatureId;
    const userId = req.user._id;

    await creaturesService.voteCreature(creatureId, userId);

    res.redirect(`/creatures/details/${creatureId}`);
});

router.get('/edit/:creatureId', async (req, res) => {
    const creature = await creaturesService.getCreatureWithId(req.params.creatureId).lean();

    res.render('creatures/edit', { creature });
});

router.post('/edit/:creatureId', async (req, res) => {
    const creatureId = req.params.creatureId;
    const creatureData = req.body;

    try {
        await creaturesService.editCreature(creatureId, creatureData);
        res.redirect(`/creatures/details/${creatureId}`);
    } catch (err) {
        res.render('creatures/edit', { errorMessage: err.message });
    }
});

router.get('/delete/:creatureId', async (req, res) => {
    try {
        await creaturesService.deleteCreature(req.params.creatureId);
        res.redirect('/creatures/all');
    } catch (err) {
        res.render('creatures/details', { errorMessage: err.message });
    }
});

module.exports = router;