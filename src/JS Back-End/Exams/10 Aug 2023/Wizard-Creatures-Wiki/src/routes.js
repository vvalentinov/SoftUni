const router = require('express').Router();

const userController = require('./controllers/userController');
const homeController = require('./controllers/homeController');
const creatureController = require('./controllers/creatureController');

router.use('/users', userController);
router.use(homeController);
router.use('/creatures', creatureController);
router.use('*', (req, res) => {
    res.render('404');
})

module.exports = router;