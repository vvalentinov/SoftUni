const User = require('../models/User');

const { generateToken } = require('../utils/generateToken');
const { validateUserPassword } = require('../utils/bcryptHelper');

exports.register = async (userData) => {
    const userWithUsername = await User.findOne({ username: userData.username });
    if (userWithUsername) {
        throw new Error('User with username already exist!');
    }

    const userWithEmail = await User.findOne({ email: userData.email });
    if (userWithEmail) {
        throw new Error('User with email already exist!');
    }

    const createdUser = await User.create(userData);

    const token = await generateToken(
        createdUser._id,
        createdUser.username,
        createdUser.email);

    return token;
};

exports.login = async (email, password) => {
    const user = await User.findOne({ email });
    if (!user) {
        throw new Error('Invalid email or password!');
    }

    const isPassValid = await validateUserPassword(password, user.password);
    if (!isPassValid) {
        throw new Error('Invalid email or password!');
    }

    const token = await generateToken(user._id, user.username, user.email);

    return token;
};