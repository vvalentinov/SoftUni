const mongoose = require('mongoose');

const { DATABASE_URI } = require('../constants/constants');

exports.dbConfig = async () => await mongoose.connect(DATABASE_URI);
