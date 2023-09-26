const User = require('../models/User');

const { generateToken } = require('../utils/generateToken');
const { validateUserPassword } = require('../utils/bcryptHelper');

exports.register = async (userData) => {
    const user = User.findOne({ username: userData.username });

    if (user) {
        throw new Error('Username already exists!');
    }

    const createdUser = await User.create(userData);

    const token = await generateToken(
        createdUser._id,
        createdUser.username,
        createdUser.email);

    return token;
};

exports.login = async (username, password) => {
    const user = User.findOne({ username });
    if (!user) {
        throw new Error('Invalid username or password!');
    }

    const isPassValid = await validateUserPassword(password, user.password);
    if (!isPassValid) {
        throw new Error('Invalid username or password!');
    }

    const token = await generateToken(user._id, user.username, user.email);

    return token;
};