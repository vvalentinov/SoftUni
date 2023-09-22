const mongoose = require('mongoose');

const cubeSchema = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Cube name is required!'],
    },
    description: {
        type: String,
        required: [true, 'Cube description is required!'],
        maxLength: [500, 'Cube description must be less than 500 characters long!'],
    },
    imageUrl: {
        type: String,
        required: [true, 'Cube image url is required!'],
    },
    difficultyLevel: {
        type: Number,
        required: [true, 'Cube difficulty number is required!'],
        min: [1, 'Cube difficulty number must be between 1 and 6!'],
        max: [6, 'Cube difficulty number must be between 1 and 6!'],
    },
    accessories: [{
        type: mongoose.Types.ObjectId,
        ref: 'Accessory',
    }],
});

const Cube = mongoose.model('Cube', cubeSchema);

module.exports = Cube;