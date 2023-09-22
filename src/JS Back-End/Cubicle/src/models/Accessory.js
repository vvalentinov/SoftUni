const mongoose = require('mongoose');

const accessorySchema = mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Accessory name is required!'],
    },
    imageUrl: {
        type: String,
        required: [true, 'Accessory image-url is required!'],
    },
    description: {
        type: String,
        required: [true, 'Accessory description is required!'],
        maxLength: [250, 'Accessory length must be less than 250!']
    },
    cubes: [{
        type: mongoose.Types.ObjectId,
        ref: 'Cube',
    }],
});

const Accessory = mongoose.model('Accessory', accessorySchema);

module.exports = Accessory;