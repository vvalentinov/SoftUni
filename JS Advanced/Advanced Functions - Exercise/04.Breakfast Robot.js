function solution() {
    const proteinError = 'Error: not enough protein in stock';
    const carbohydrateError = 'Error: not enough carbohydrate in stock';
    const fatError = 'Error: not enough fat in stock';
    const flavourError = 'Error: not enough flavour in stock';

    const successMessage = 'Success';

    let microelements = { protein: 0, carbohydrate: 0, fat: 0, flavour: 0 };

    return function manage(input) {
        let array = input.split(' ');
        if (array.length == 1) {
            return `protein=${microelements.protein} carbohydrate=${microelements.carbohydrate} fat=${microelements.fat} flavour=${microelements.flavour}`;
        } else {
            let command = array[0];
            let item = array[1];
            let quantity = Number(array[2]);

            if (command == 'restock') {
                microelements[item] += quantity;
                return successMessage;
            } else if (command == 'prepare') {
                let neededCarbohydrate = 0;
                let neededFlavour = 0;
                let neededFat = 0;
                let neededProtein = 0;
                switch (item) {
                    case 'apple':
                        neededCarbohydrate = quantity;
                        if (neededCarbohydrate > microelements.carbohydrate) {
                            return carbohydrateError;
                        }
                        neededFlavour = 2 * quantity;
                        if (neededFlavour > microelements.flavour) {
                            return flavourError;
                        }
                        microelements.carbohydrate -= neededCarbohydrate;
                        microelements.flavour -= neededFlavour;
                        break;
                    case 'lemonade':
                        neededCarbohydrate = 10 * quantity;
                        if (neededCarbohydrate > microelements.carbohydrate) {
                            return carbohydrateError;
                        }
                        neededFlavour = 20 * quantity;
                        if (neededFlavour > microelements.flavour) {
                            return flavourError;
                        }
                        microelements.carbohydrate -= neededCarbohydrate;
                        microelements.flavour -= neededFlavour;
                        break;
                    case 'burger':
                        neededCarbohydrate = 5 * quantity;
                        if (neededCarbohydrate > microelements.carbohydrate) {
                            return carbohydrateError;
                        }

                        neededFlavour = 3 * quantity;
                        if (neededFlavour > microelements.flavour) {
                            return flavourError;
                        }
                        neededFat = 7 * quantity;
                        if (neededFat > microelements.fat) {
                            return fatError;
                        }
                        microelements.carbohydrate -= neededCarbohydrate;
                        microelements.flavour -= neededFlavour;
                        microelements.fat -= neededFat;
                        break;
                    case 'eggs':
                        neededProtein = 5 * quantity;
                        if (neededProtein > microelements.protein) {
                            return proteinError;
                        }
                        neededFat = quantity;
                        if (neededFat > microelements.fat) {
                            return fatError;
                        }
                        neededFlavour = quantity;
                        if (neededFlavour > microelements.flavour) {
                            return flavourError;
                        }
                        microelements.protein -= neededProtein;
                        microelements.fat -= neededFat;
                        microelements.flavour -= neededFlavour;
                        break;
                    case 'turkey':
                        neededProtein = 10 * quantity;
                        if (neededProtein > microelements.protein) {
                            return proteinError;
                        }
                        neededCarbohydrate = 10 * quantity;
                        if (neededCarbohydrate > microelements.carbohydrate) {
                            return carbohydrateError;
                        }
                        neededFat = 10 * quantity;
                        if (neededFat > microelements.fat) {
                            return fatError;
                        }
                        neededFlavour = 10 * quantity;
                        if (neededFlavour > microelements.flavour) {
                            return flavourError;
                        }
                        microelements.protein -= neededProtein;
                        microelements.flavour -= neededFlavour;
                        microelements.carbohydrate -= neededCarbohydrate;
                        microelements.fat -= neededFat;
                        break;
                }
                return successMessage;
            }
        }
    }
}