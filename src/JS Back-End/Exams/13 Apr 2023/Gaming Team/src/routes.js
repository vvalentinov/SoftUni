const router = require('express').Router();

const userController = require('./controllers/userController');
const homeController = require('./controllers/homeController');
const gameController = require('./controllers/gameController');

router.use('/user', userController);
router.use(homeController);
router.use('/games', gameController);

module.exports = router;