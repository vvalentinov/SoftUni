function sortArray(array, criteria) {
    let result = [];
    if (criteria == 'asc') {
        result = array.sort((a, b) => a - b);
    } else {
        result = array.sort((a, b) => b - a);
    }
    return result;
}