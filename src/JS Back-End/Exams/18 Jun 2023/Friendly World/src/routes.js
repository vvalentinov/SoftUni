const router = require('express').Router();

const userController = require('./controllers/userController');
const homeController = require('./controllers/homeController');
const animalController = require('./controllers/animalController');

router.use('/users', userController);
router.use(homeController);
router.use('/animals', animalController);
router.use('*', (req, res) => {
    res.render('404');
});

module.exports = router;