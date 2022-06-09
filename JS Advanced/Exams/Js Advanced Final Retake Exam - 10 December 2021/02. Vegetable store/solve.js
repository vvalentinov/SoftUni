class VegetableStore {
    constructor(owner, location) {
        this.owner = owner;
        this.location = location;
        this.availableProducts = [];
    }

    loadingVegetables(vegetables) {
        let types = [];
        vegetables.forEach(currVegetable => {
            let [type, quantity, price] = currVegetable.split(' ');
            quantity = Number(quantity);
            price = Number(price);

            let vegetable = this.availableProducts.find(v => v.type == type);
            if (vegetable) {
                vegetable.quantity += quantity;
                if (price > vegetable.price) {
                    vegetable.price = price;
                }
            } else {
                this.availableProducts.push({ type, quantity, price });
                if (!types.includes(type)) {
                    types.push(type);
                }
            }
        });
        return `Successfully added ${types.join(', ')}`;
    }

    buyingVegetables(selectedProducts) {
        let totalPrice = 0;
        selectedProducts.forEach(product => {
            let [type, quantity] = product.split(' ');
            quantity = Number(quantity);

            let productWithType = this.availableProducts.find(p => p.type == type);
            if (productWithType == undefined) {
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }
            if (quantity > productWithType.quantity) {
                throw new Error(`The quantity ${quantity} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }

            totalPrice += productWithType.price * quantity;
            productWithType.quantity -= quantity;
        });
        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`;
    }

    rottingVegetable(type, quantity) {
        let productWithType = this.availableProducts.find(p => p.type == type);
        if (productWithType == undefined) {
            throw new Error(`${type} is not available in the store.`);
        }
        if (quantity > productWithType.quantity) {
            productWithType.quantity = 0;
            return `The entire quantity of the ${type} has been removed.`;
        }
        productWithType.quantity -= quantity;
        return `Some quantity of the ${type} has been removed.`;
    }

    revision() {
        let message = 'Available vegetables:\n';
        let availableProducts = this.availableProducts.sort((a, b) => a.price - b.price);
        availableProducts.forEach(product => {
            message += `${product.type}-${product.quantity}-$${product.price}\n`;
        });
        message += `The owner of the store is ${this.owner}, and the location is ${this.location}.`;
        return message;
    }
}