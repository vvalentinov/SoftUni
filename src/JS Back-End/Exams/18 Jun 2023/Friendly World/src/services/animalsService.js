const Animal = require('../models/Animal');

exports.add = (animalData) => Animal.create(animalData);

exports.getAll = () => Animal.find();

exports.getAnimalWithId = (animalId) => Animal.findById(animalId);

exports.donateToAnimalWithId = async (animalId, userId) => {
    const animal = await Animal.findById(animalId);
    animal.donations.push(userId);
    return animal.save();
};

exports.getLatestThreeAnimals = () => Animal.find().sort({ _id: -1 }).limit(3);

exports.editAnimal = (animalId, animalData) => Animal.findByIdAndUpdate(animalId, animalData);

exports.deleteAnimal = (animalId) => Animal.findByIdAndDelete(animalId);

exports.searchAnimals = (location) => Animal.find({ location: { $regex: new RegExp("^" + location.toLowerCase(), "i") } });