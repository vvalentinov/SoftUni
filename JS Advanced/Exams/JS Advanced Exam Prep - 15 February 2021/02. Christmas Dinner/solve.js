class ChristmasDinner{
    constructor(budget){
        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    get budget(){
        return this._budget;
    }

    set budget(value){
        if (value < 0) {
            throw new Error('The budget cannot be a negative number');
        }
        this._budget = value;
    }

    shopping(product){
        let productType = product[0];
        let productPrice = Number(product[1]);
        if (productPrice > this._budget) {
            throw new Error('Not enough money to buy this product');
        }
        this.products.push(productType);
        this._budget -= productPrice;
        return `You have successfully bought ${productType}!`;
    }

    recipes(recipe){
        let recipeName = recipe.recipeName;
        let productsList = recipe.productsList;

        let productsAreAvailable = productsList.every(x => this.products.includes(x));
        if (productsAreAvailable == false) {
            throw new Error('We do not have this product');
        }
        this.dishes.push({recipeName, productsList});
        return `${recipeName} has been successfully cooked!`;
    }

    inviteGuests(name, dish){
        if (this.dishes.find(d => d.recipeName == dish) == undefined) {
            throw new Error('We do not have this dish');
        }

        if (this.guests[name]) {
            throw new Error('This guest has already been invited');
        }

        this.guests[name] = dish;
        return `You have successfully invited ${name}!`;
    }

    showAttendance(){
        let result = [];
        for (const guest in this.guests) {
            let dish = this.dishes.find(d => d.recipeName == this.guests[guest]);
            result.push(`${guest} will eat ${this.guests[guest]}, which consists of ${dish.productsList.join(', ')}`);
        }
        return result.join('\n');
    }
}