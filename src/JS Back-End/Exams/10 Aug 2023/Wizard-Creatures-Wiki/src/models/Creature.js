const mongoose = require('mongoose');

const creatureSchema = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Creature name is required!'],
    },
    species: {
        type: String,
        required: [true, 'Creature species is required!'],
    },
    skinColor: {
        type: String,
        required: [true, 'Creature skin color is required!'],
    },
    eyeColor: {
        type: String,
        required: [true, 'Creature eyeColor is required!'],
    },
    image: {
        type: String,
        required: [true, 'Creature image is required!'],
    },
    description: {
        type: String,
        required: [true, 'Creature description is required!'],
    },
    votes: [{ type: mongoose.Types.ObjectId }],
    owner: {
        type: mongoose.Types.ObjectId,
        ref: 'User',
    },
});

const Creature = mongoose.model('Creature', creatureSchema);

module.exports = Creature;