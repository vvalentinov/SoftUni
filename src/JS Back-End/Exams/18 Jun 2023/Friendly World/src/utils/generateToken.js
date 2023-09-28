const jwt = require('../lib/jwt');

const { JWT_SECRET } = require('../constants/constants');

exports.generateToken = async (_id, email) => {
    const payload = { _id, email };

    const token = await jwt.sign(payload, JWT_SECRET, { expiresIn: '2d' });

    return token;
};