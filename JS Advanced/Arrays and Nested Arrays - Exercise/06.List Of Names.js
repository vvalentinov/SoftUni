function listOfNames(input) {
    input.sort((a, b) => a.localeCompare(b)).forEach((el, index) => {
        console.log(`${index + 1}.${el}`);
    });
}

listOfNames(["John", "Bob", "Christina", "Ema"]);