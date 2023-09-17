exports.validateCat = (fields) => {
    if ((!Object.hasOwn(fields, 'name') || fields['name'][0] == '') ||
        (!Object.hasOwn(fields, 'description') || fields['description'][0] == '') ||
        (!Object.hasOwn(fields, 'breed') || fields['breed'][0] == '')) {
        return false;
    }

    return true;
};