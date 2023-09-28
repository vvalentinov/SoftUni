const Creature = require('../models/Creature');

exports.addCreature = (creatureData) => Creature.create(creatureData);

exports.getAllCreatures = () => Creature.find().populate('owner');

exports.getCreatureWithId = (creatureId) => Creature.findById(creatureId).populate('owner');

exports.voteCreature = async (creatureId, userId) => {
    const creature = await Creature.findById(creatureId);
    creature.votes.push({ _id: userId });
    return creature.save();
};

exports.getCreatureUsersVotes = async (creatureId) => {
    const creature = await Creature.findById(creatureId).populate('votes');
    const emails = creature.votes.map(vote => vote.email);
    return emails;
};

exports.editCreature = (creatureId, creatureData) => Creature.findByIdAndUpdate(creatureId, creatureData);

exports.deleteCreature = (creatureId) => Creature.findByIdAndDelete(creatureId);

exports.getUserCreatures = (userId) => Creature.find({ owner: userId });