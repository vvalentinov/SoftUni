function createSortedList() {
    let array = [];
    return {
        add: function (element) {
            array.push(element);
            array = array.sort((a, b) => a - b);
            this.size++;
        },
        remove: function (index) {
            if (index >= 0 && index < this.size) {
                array.splice(index, 1);
                array = array.sort((a, b) => a - b);
                this.size--;
            }
        },
        get: function (index) {
            if (index >= 0 && index < this.size) {
                return array[index];
            }
        },
        'size': 0,
    };
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
