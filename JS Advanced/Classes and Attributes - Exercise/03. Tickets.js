function solve(ticketsDescriptions, sortingCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let tickets = [];
    ticketsDescriptions.forEach(x => {
        let [destination, price, status] = x.split('|');
        price = Number(price);
        tickets.push(new Ticket(destination, price, status));
    });


    switch (sortingCriteria) {
        case 'destination':
            tickets.sort((a, b) => a.destination.localeCompare(b.destination));
            break;
        case 'price':
            tickets.sort((a, b) => a.price - b.price);
            break;
        case 'status':
            tickets.sort((a, b) => a.status.localeCompare(b.status));
            break;
    }

    return tickets;
}