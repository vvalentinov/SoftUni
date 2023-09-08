class Restaurant {
    constructor(budgetMoney) {
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(products) {
        products.forEach(productInfo => {
            let [name, quantity, totalPrice] = productInfo.split(' ');
            quantity = Number(quantity);
            totalPrice = Number(totalPrice);
            if (totalPrice <= this.budgetMoney) {
                this.stockProducts[name] = name in this.stockProducts ? this.stockProducts[name] + quantity : quantity;
                this.budgetMoney -= totalPrice;
                this.history.push(`Successfully loaded ${quantity} ${name}`);
            } else {
                this.history.push(`There was not enough money to load ${quantity} ${name}`);
            }
        });
        return this.history.join('\n');
    }

    addToMenu(meal, neededProducts, price) {
        if (meal in this.menu) {
            return `The ${meal} is already in the our menu, try something different.`;
        } else {
            this.menu[meal] = { products: neededProducts, price };
            let meals = Object.keys(this.menu).length;
            if (meals != 1) {
                return `Great idea! Now with the ${meal} we have ${meals} meals in the menu, other ideas?`;
            }
            return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`;
        }
    }

    showTheMenu() {
        let result = [];
        if (Object.keys(this.menu).length == 0) {
            return 'Our menu is not ready yet, please come later...';
        } else {
            for (const key in this.menu) {
                result.push(`${key} - $ ${this.menu[key].price}`);
            }
        }
        return result.join('\n');
    }

    makeTheOrder(meal) {
        if (meal in this.menu == false) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`;
        }

        let neededProducts = this.menu[meal].products;
        for (let index = 0; index < neededProducts.length; index++) {
            let [productName, productQuantity] = neededProducts[index].split(' ');
            if (productName in this.stockProducts == false || this.stockProducts[productName] < productQuantity) {
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
            } else {
                this.stockProducts[productName] -= productQuantity;
            }
        }

        this.budgetMoney += this.menu[meal].price;
        return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`;
    }
}