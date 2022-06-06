function solution() {
    let result = '';
    return {
        append: function append(string) {
            result += string;
        },
        removeStart: function removeStart(n) {
            result = result.slice(n, result.length);
        },
        removeEnd: function removeEnd(n) {
            result = result.slice(0, result.length - n);
        },
        print: function print() {
            console.log(result);
        }
    }
}