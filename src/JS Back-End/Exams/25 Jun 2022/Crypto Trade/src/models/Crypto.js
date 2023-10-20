const mongoose = require('mongoose');

const cryptoSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
    },
    image: {
        type: String,
        required: true,
    },
    price: {
        type: Number,
        required: true,
    },
    cryptoDescription: {
        type: String,
        required: true,
    },
    paymentMethod: {
        type: String,
        enum: ['crypto-wallet', 'credit-card', 'debit-card', 'paypal'],
        required: true,
    },
    buyCripto: [{
        type: mongoose.Types.ObjectId,
        ref: 'User',
    }],
    owner: {
        type: mongoose.Types.ObjectId,
        ref: 'User',
    },
}, {
    statics: {
        findByNameAndPaymentMethod(name, paymentMethod) {
            return this.find({
                name: new RegExp(name, 'i'),
                paymentMethod: new RegExp(paymentMethod, 'i')
            });
        }
    }
});

const Crypto = mongoose.model('Crypto', cryptoSchema);

module.exports = Crypto;