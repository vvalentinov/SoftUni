const Crypto = require('../models/Crypto');

exports.create = (cryptoOfferData) => Crypto.create(cryptoOfferData);

exports.getAll = () => Crypto.find({});

exports.getById = (offerId) => Crypto.findById(offerId);

exports.buyCripto = async (userId, offerId) => {
    const offer = await Crypto.findById(offerId);
    offer.buyCripto.push(userId);
    await offer.save();
};