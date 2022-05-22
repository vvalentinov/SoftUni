function fromJSONToHTMLTable(input) {
    const object = JSON.parse(input);

    console.log('<table>');

    const objectKeys = Object.keys(object[0]);
    let result = '<tr>';
    for (let index = 0; index < objectKeys.length; index++) {
        const element = escapeHtml(objectKeys[index]).trim();
        result += `<th>${element}</th>`;
    }
    result += '</tr>';
    console.log(result);

    for (let index = 0; index < object.length; index++) {
        const element = object[index];
        const objectValues = Object.values(element);
        let string = '<tr>';
        for (const key in objectValues) {
            string += `<td>${escapeHtml(objectValues[key])}</td>`;
        }
        string += '</tr>';
        console.log(string);
    }

    console.log('</table>');

    function escapeHtml(value) {
        return value
            .toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}

fromJSONToHTMLTable(`[{"Name":"Stamat","Score":5.5},{"Name":"Rumen","Score":6}]`);
fromJSONToHTMLTable(`[{"Name":"Pesho","Score":4," Grade":8},{"Name":"Gosho","Score":5," Grade":8},{"Name":"Angel","Score":5.50," Grade":10}]`);