class SummerCamp {
    constructor(organizer, location) {
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = {
            'child': 150,
            'student': 300,
            'collegian': 500,
        };
        this.listOfParticipants = [];
    }

    registerParticipant(name, condition, money) {
        if (this.priceForTheCamp.hasOwnProperty(condition) == false) {
            throw new Error('Unsuccessful registration at the camp.');
        }

        if (this.listOfParticipants.find(p => p.name == name)) {
            return `The ${name} is already registered at the camp.`;
        }

        if (money < this.priceForTheCamp[condition]) {
            return 'The money is not enough to pay the stay at the camp.';
        }
        this.listOfParticipants.push({ name, condition, power: 100, wins: 0 });
        return `The ${name} was successfully registered.`;
    }

    unregisterParticipant(name) {
        let person = this.listOfParticipants.find(p => p.name == name);
        if (!person) {
            throw new Error(`The ${name} is not registered in the camp.`);
        }
        this.listOfParticipants.splice(this.listOfParticipants.indexOf(person), 1);
        return `The ${name} removed successfully.`;
    }

    timeToPlay(typeOfGame, participant1, participant2) {
        let firstParticipant = this.listOfParticipants.find(p => p.name == participant1);
        if (!firstParticipant) {
            throw new Error('Invalid entered name/s.');
        }
        if (typeOfGame == 'WaterBalloonFights') {
            let secondParticipant = this.listOfParticipants.find(p => p.name == participant2);

            if (!secondParticipant) {
                throw new Error('Invalid entered name/s.');
            }

            if (firstParticipant.condition != secondParticipant.condition) {
                throw new Error('Choose players with equal condition.');
            }

            if (firstParticipant.power == secondParticipant.power) {
                return 'There is no winner.';
            }

            let winner = '';
            if (firstParticipant.power > secondParticipant.power) {
                firstParticipant.wins += 1;
                winner = firstParticipant.name;
            } else {
                secondParticipant.wins += 1;
                winner = secondParticipant.name;
            }

            return `The ${winner} is winner in the game ${typeOfGame}.`;
        } else {
            firstParticipant.power += 20;
            return `The ${firstParticipant.name} successfully completed the game ${typeOfGame}.`;
        }
    }

    toString() {
        let result = [];
        result.push(`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);

        let sortedParticipants = this.listOfParticipants.sort((a, b) => b.wins - a.wins);
        sortedParticipants.forEach(p => { result.push(`${p.name} - ${p.condition} - ${p.power} - ${p.wins}`); });
        return result.join('\n');
    }
}