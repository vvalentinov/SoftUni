const Game = require('../models/Game');

exports.create = (gameData) => Game.create(gameData);

exports.getAll = () => Game.find();

exports.getGameWithId = (gameId) => Game.findById(gameId);

exports.buyGame = async (gameId, userId) => {
    const game = await Game.findById(gameId);
    game.boughtBy.push(userId);
    return game.save();
};

exports.editGame = (gameId, gameData) => Game.findByIdAndUpdate(gameId, gameData);

exports.deleteGame = (gameId) => Game.findByIdAndDelete(gameId);

exports.findGamesWithNameAndPlatform = (name, platform) => Game.find({
    name: { $regex: new RegExp("^" + name.toLowerCase(), "i") },
    platform: { $regex: new RegExp("^" + platform.toLowerCase(), "i") },
});