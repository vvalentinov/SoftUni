const mongoose = require('mongoose');

const { generateHash } = require('../utils/bcryptHelper');

const userSchema = new mongoose.Schema({
    firstName: {
        type: String,
        required: [true, 'User first name is required!'],
        minLength: [3, 'User\'s first name should be at least 3 characters long!'],
    },
    lastName: {
        type: String,
        required: [true, 'User last name is required!'],
        minLength: [3, 'User\'s last name should be at least 3 characters long!'],
    },
    email: {
        type: String,
        required: [true, 'User email is required!'],
        minLength: [10, 'User\'s email should be at least 10 characters long!'],
        unique: [true, 'Email is already in use!'],
    },
    password: {
        type: String,
        required: [true, 'User password is required!'],
        minLength: [4, 'User\'s password should be at least 4 characters long!'],
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