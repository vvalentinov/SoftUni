function solve(area, vol, input) {
    let coordinatesSet = JSON.parse(input);
    let result = [];
    for (const set of coordinatesSet) {
        result.push({ area: area.call(set), volume: vol.call(set) });
    }
    return result;
}