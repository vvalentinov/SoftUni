const mongoose = require('mongoose');

const { generateHash } = require('../utils/bcryptHelper');

const userSchema = new mongoose.Schema({
    firstName: {
        type: String,
        required: [true, 'User first name is required!'],
    },
    lastName: {
        type: String,
        required: [true, 'User last name is required!'],
    },
    email: {
        type: String,
        required: [true, 'User email is required!'],
    },
    password: {
        type: String,
        required: [true, 'User password is required!'],
    },
});

userSchema.virtual('repeatPassword').set(function (value) {
    if (value !== this.password) {
        throw new Error('Password and repeat-password must be the same!');
    }
});

userSchema.pre('save', async function () {
    const hash = await generateHash(this.password, 10);

    this.password = hash;
});

const User = mongoose.model('User', userSchema);

module.exports = User;