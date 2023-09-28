const mongoose = require('mongoose');

const animalScheama = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Animal name is required!'],
    },
    years: {
        type: Number,
        required: [true, 'Animal years is required!'],
    },
    kind: {
        type: String,
        required: [true, 'Animal kind is required!'],
    },
    image: {
        type: String,
        required: [true, 'Animal image is required!'],
    },
    need: {
        type: String,
        required: [true, 'Animal need is required!'],
    },
    location: {
        type: String,
        required: [true, 'Animal location is required!'],
    },
    description: {
        type: String,
        required: [true, 'Animal description is required!'],
    },
    donations: [{
        type: mongoose.Types.ObjectId,
    }],
    owner: {
        type: mongoose.Types.ObjectId,
        ref: 'User',
    },
});

const Animal = mongoose.model('Animal', animalScheama);

module.exports = Animal;