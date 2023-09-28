const mongoose = require('mongoose');

const creatureSchema = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Creature name is required!'],
        minLength: [2, 'Creature name must be at least 2 characters long!'],
    },
    species: {
        type: String,
        required: [true, 'Creature species is required!'],
        minLength: [3, 'Creature species must be at least 3 characters long!'],
    },
    skinColor: {
        type: String,
        required: [true, 'Creature skin color is required!'],
        minLength: [3, 'Creature skinColor must be at least 3 characters long!'],
    },
    eyeColor: {
        type: String,
        required: [true, 'Creature eyeColor is required!'],
        minLength: [3, 'Creature eyeColor must be at least 3 characters long!'],
    },
    image: {
        type: String,
        required: [true, 'Creature image is required!'],
        match: [/^https?:\/\//, 'Creature image must start with either http:// or https://'],
    },
    description: {
        type: String,
        required: [true, 'Creature description is required!'],
        minLength: [5, 'Creature description must be between 5 and 500 characters long!'],
        maxLength: [500, 'Creature description must be between 5 and 500 characters long!']
    },
    votes: [{ type: mongoose.Types.ObjectId, ref: 'User' }],
    owner: {
        type: mongoose.Types.ObjectId,
        ref: 'User',
    },
});

const Creature = mongoose.model('Creature', creatureSchema);

module.exports = Creature;