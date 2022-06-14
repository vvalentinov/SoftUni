class List {
    #array = [];
    constructor() {
        this.size = this.#array.length;
    }

    add(element) {
        this.#array.push(element);
        this.size++;
        this.#array.sort((a, b) => a - b);
    }

    remove(index) {
        if (index >= 0 && index < this.#array.length) {
            this.#array.splice(index, 1);
            this.size--;
            this.#array.sort((a, b) => a - b);
        }
    }

    get(index) {
        if (index >= 0 && index < this.#array.length) {
            return this.#array[index];
        }
    }
}