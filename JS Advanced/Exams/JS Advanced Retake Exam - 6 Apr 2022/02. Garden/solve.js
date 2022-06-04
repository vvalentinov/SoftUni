class Garden {
    constructor(spaceAvailable) {
        this.spaceAvailable = spaceAvailable;
        this.plants = [];
        this.storage = [];
    }

    addPlant(plantName, spaceRequired) {
        if (this.spaceAvailable < spaceRequired) {
            throw new Error('Not enough space in the garden.');
        }

        this.plants.push({ plantName, spaceRequired, ripe: false, quantity: 0 });
        this.spaceAvailable -= spaceRequired;
        return `The ${plantName} has been successfully planted in the garden.`;
    }

    ripenPlant(plantName, quantity) {
        let plant = this.plants.find(p => p.plantName == plantName);
        if (plant == undefined) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        if (plant.ripe) {
            throw new Error(`The ${plantName} is already ripe.`);
        }
        if (quantity <= 0) {
            throw new Error('The quantity cannot be zero or negative.');
        }

        plant.ripe = true;
        plant.quantity += quantity;
        if (quantity == 1) {
            return `${quantity} ${plantName} has successfully ripened.`;
        } else {
            return `${quantity} ${plantName}s have successfully ripened.`;
        }
    }

    harvestPlant(plantName) {
        let plant = this.plants.find(p => p.plantName == plantName);
        if (plant == undefined) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        if (!plant.ripe) {
            throw new Error(`The ${plantName} cannot be harvested before it is ripe.`);
        }
        let plantIndex = this.plants.indexOf(plant);
        this.plants.splice(plantIndex, 1);
        this.storage.push({ plantName, quantity: plant.quantity });
        this.spaceAvailable += plant.spaceRequired;

        return `The ${plantName} has been successfully harvested.`;
    }

    generateReport() {
        let result = `The garden has ${this.spaceAvailable} free space left.\n`;
        let plants = this.plants.sort((a, b) => a.plantName.localeCompare(b.plantName)).map(p => p.plantName);
        result += `Plants in the garden: ${plants.join(', ')}\n`;
        if (this.storage.length == 0) {
            result += 'Plants in storage: The storage is empty.';
        } else {
            result += `Plants in storage: ${this.storage.map(({ plantName, quantity }) => `${plantName} (${quantity})`).join(', ')}`;
        }
        return result;
    }
}