const router = require('express').Router();

const homeController = require('./controllers/homeController');
const userController = require('./controllers/userController');
const cryptoController = require('./controllers/cryptoController');

router.use(homeController);
router.use('/user', userController);
router.use('/crypto', cryptoController);

module.exports = router;