const Animal = require('../models/Animal');

exports.add = (animalData) => Animal.create(animalData);

exports.getAll = () => Animal.find();