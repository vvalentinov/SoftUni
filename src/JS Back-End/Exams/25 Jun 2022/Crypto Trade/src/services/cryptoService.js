const Crypto = require('../models/Crypto');

exports.create = (cryptoOfferData) => Crypto.create(cryptoOfferData);