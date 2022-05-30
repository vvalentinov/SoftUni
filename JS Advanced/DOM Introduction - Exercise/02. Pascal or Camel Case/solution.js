function solve() {
  let conventionElementValue = document.getElementById('naming-convention').value;
  let textElementValue = document.getElementById('text').value.toLowerCase();
  let words = textElementValue.split(' ');
  let result = '';
  let resultElement = document.getElementById('result');
  if (conventionElementValue == 'Camel Case') {
    result += words[0];
    for (let index = 1; index <= words.length - 1; index++) {
      const element = words[index].charAt(0).toUpperCase() + words[index].slice(1);
      result += element;
    }
  } else if (conventionElementValue == 'Pascal Case') {
    for (let index = 0; index < words.length; index++) {
      const element = words[index].charAt(0).toUpperCase() + words[index].slice(1);
      result += element;
    }
  } else {
    result = 'Error!';
  }
  resultElement.textContent = result;
}