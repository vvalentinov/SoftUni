function wordsUppercase(input) {
    const pattern = /\w+/gm;
    const array = input.match(pattern).map(x => x.toUpperCase());
    console.log(array.join(', '));
}

wordsUppercase('Hi, how are you?');
wordsUppercase('hello');