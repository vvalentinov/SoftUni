function radar(speed, area) {
    const motorwaySpeedLimit = 130;
    const interstateSpeedLimit = 90;
    const citySpeedLimit = 50;
    const residentialAreaSpeedLimit = 20;

    let difference = 0;
    let speedLimit = 0;
    switch (area) {
        case 'motorway':
            if (speed <= motorwaySpeedLimit) {
                console.log(`Driving ${speed} km/h in a 130 zone`);
            } else {
                difference = speed - motorwaySpeedLimit;
                speedLimit = motorwaySpeedLimit;
            }
            break;
        case 'interstate':
            if (speed <= interstateSpeedLimit) {
                console.log(`Driving ${speed} km/h in a 90 zone`);
            } else {
                difference = speed - interstateSpeedLimit;
                speedLimit = interstateSpeedLimit;
            }
            break;
        case 'city':
            if (speed <= citySpeedLimit) {
                console.log(`Driving ${speed} km/h in a 50 zone`);
            } else {
                difference = speed - citySpeedLimit;
                speedLimit = citySpeedLimit;
            }
            break;
        case 'residential':
            if (speed <= residentialAreaSpeedLimit) {
                console.log(`Driving ${speed} km/h in a 20 zone`);
            } else {
                difference = speed - residentialAreaSpeedLimit;
                speedLimit = residentialAreaSpeedLimit;
            }
            break;
    }
    if (difference !== 0) {
        if (difference <= 20) {
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - speeding`);
        } else if (difference <= 40) {
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - excessive speeding`);
        } else {
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - reckless driving`);
        }
    }
}

radar(40, 'city');
radar(21, 'residential');
radar(120, 'interstate');
radar(200, 'motorway');
