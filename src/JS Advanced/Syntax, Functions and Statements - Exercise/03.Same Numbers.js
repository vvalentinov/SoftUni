function sameNumbers(number) {
    const array = Array.from(String(number), x => Number(x));
    console.log(array.every(x => x === array[0]));
    console.log(array.reduce((previousValue, currentValue) => previousValue + currentValue, 0));
}

sameNumbers(2222222);
sameNumbers(1234);