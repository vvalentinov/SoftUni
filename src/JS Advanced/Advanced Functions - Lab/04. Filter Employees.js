function filter(data, criteria) {
    let employees = JSON.parse(data);
    let counter = 0;
    if (criteria == 'all') {

        employees.forEach(x => {
            console.log(`${counter++}. ${x.first_name} ${x.last_name} - ${x.email}`);
        });

    } else {
        let arr = criteria.split('-');
        let propertry = arr[0];
        let value = arr[1];

        employees.filter(x => x[propertry] === value).forEach(x => {
            console.log(`${counter++}. ${x.first_name} ${x.last_name} - ${x.email}`);
        });
    }
}