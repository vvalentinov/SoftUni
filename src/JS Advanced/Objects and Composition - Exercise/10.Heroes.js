function solve() {
    return {
        fighter: function (name) {
            let fighter = {
                name,
                'health': 100,
                'stamina': 100,
                fight: function () {
                    this.stamina--;
                    console.log(`${this.name} slashes at the foe!`);
                }
            }
            return fighter;
        },
        mage: function (name) {
            let mage = {
                name,
                'health': 100,
                'mana': 100,
                cast: function (spell) {
                    this.mana--;
                    console.log(`${this.name} cast ${spell}`);
                }
            }
            return mage;
        }
    }
}