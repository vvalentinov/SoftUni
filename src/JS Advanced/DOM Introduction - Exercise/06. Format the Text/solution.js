function solve() {
  let outputElement = document.getElementById('output');

  let inputElement = document.getElementById('input');
  let inputText = inputElement.value;

  let sentences = inputText.split('.');
  sentences.pop();
  let formattedText = '';
  let result = '';
  if (sentences.length <= 3) {
    for (let index = 0; index < sentences.length; index++) {
      const sentence = sentences[index] + '.';
      formattedText += sentence;
    }
    result = `<p>${formattedText}</p>`;
  } else {
    for (let index = 0; index < sentences.length; index += 3) {
      if (index == sentences.length - 1) {
        const sentence = sentences[index] + '.';
        result += `<p>${sentence}</p>`;
      } else {
        let firstSentence = sentences[index] + '.';
        let secondSentence = '';
        if (index + 1 < sentences.length) {
          secondSentence = sentences[index + 1] + '.'
        }
        let thirdSentence = '';
        if (index + 2 < sentences.length) {
          thirdSentence = sentences[index + 2] + '.'
        }
        result += `<p>${firstSentence + secondSentence + thirdSentence}</p>`;
      }
    }
  }

  outputElement.innerHTML = result;
}