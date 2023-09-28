const mongoose = require('mongoose');

const animalScheama = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Animal name is required!'],
        minLength: [2, 'Animal name should be at least 2 characters long!'],
    },
    years: {
        type: Number,
        required: [true, 'Animal years is required!'],
        min: [1, 'Animal years must be between 1 and 100!'],
        max: [100, 'Animal years must be between 1 and 100!'],
    },
    kind: {
        type: String,
        required: [true, 'Animal kind is required!'],
        minLength: [3, 'Animal kind should be at least 3 characters long!'],
    },
    image: {
        type: String,
        required: [true, 'Animal image is required!'],
        match: [/^https?:\/\//, 'Animal image must start with either http:// or https://'],
    },
    need: {
        type: String,
        required: [true, 'Animal need is required!'],
        minLength: [3, 'Animal need should be at least 3 characters long!'],
        maxLength: [20, 'Animal need should be at least 20 characters long!'],
    },
    location: {
        type: String,
        required: [true, 'Animal location is required!'],
        minLength: [5, 'Animal location should be at least 5 characters long!'],
        maxLength: [15, 'Animal location should be at least 15 characters long!'],
    },
    description: {
        type: String,
        required: [true, 'Animal description is required!'],
        minLength: [5, 'Animal description should be at least 5 characters long!'],
        maxLength: [50, 'Animal description should be at least 50 characters long!'],
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