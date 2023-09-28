const mongoose = require('mongoose');

const { generateHash } = require('../utils/bcryptHelper');

const userSchema = new mongoose.Schema({
    email: {
        type: String,
        required: [true, 'User email is required!'],
        minLength: [10, 'Email should be at least 10 characters long!'],
        unique: [true, 'Email aready in use!'],
    },
    password: {
        type: String,
        required: [true, 'User password is required!'],
        minLength: [4, 'Password should be at least 4 characters long!'],
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