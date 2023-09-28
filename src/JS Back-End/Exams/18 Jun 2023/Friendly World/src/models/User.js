const mongoose = require('mongoose');

const { generateHash } = require('../utils/bcryptHelper');

const userSchema = new mongoose.Schema({
    username: {
        type: String,
        required: true,
        unique: true,
    },
    email: {
        type: String,
        required: true,
    },
    password: {
        type: String,
        required: true
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