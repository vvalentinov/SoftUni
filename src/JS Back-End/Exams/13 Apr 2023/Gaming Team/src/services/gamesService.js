const Game = require('../models/Game');

exports.create = (gameData) => Game.create(gameData);

exports.getAll = () => Game.find();

exports.getGameWithId = (gameId) => Game.findById(gameId);

exports.buyGame = async (gameId, userId) => {
    const game = await Game.findById(gameId);
    game.boughtBy.push(userId);
    return game.save();
};

exports.editGame = async (gameId, gameData) => Game.findByIdAndUpdate(gameId, gameData);