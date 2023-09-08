function checker(x1, y1, x2, y2) {
    let firstResult = Math.sqrt(Math.pow((0 - x1), 2) + Math.pow((0 - y1), 2));
    if (firstResult % 1 === 0) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    let secondResult = Math.sqrt(Math.pow((0 - x2), 2) + Math.pow((0 - y2), 2));
    if (secondResult % 1 === 0) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    let thirdResult = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));
    if (thirdResult % 1 === 0) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

checker(3, 0, 0, 4);
checker(2, 1, 1, 1);