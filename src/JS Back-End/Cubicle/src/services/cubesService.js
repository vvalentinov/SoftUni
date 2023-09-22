const Cube = require('../models/Cube');

exports.addCube = async (cubeData) => {
    const cube = new Cube(cubeData);
    await cube.save();
};