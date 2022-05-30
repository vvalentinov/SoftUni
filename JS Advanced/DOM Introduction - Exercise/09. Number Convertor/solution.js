function solve() {
    let selectMenuToElement = document.getElementById('selectMenuTo');

    let binaryOption = document.createElement('option');
    let hexadecimalOption = document.createElement('option');

    binaryOption.value = 'binary';
    binaryOption.text = 'Binary';

    hexadecimalOption.value = 'hexadecimal';
    hexadecimalOption.text = 'Hexadecimal';

    selectMenuToElement.add(binaryOption, null);
    selectMenuToElement.add(hexadecimalOption, null);


    let convertButtonElement = document.getElementsByTagName('button')[0];
    convertButtonElement.addEventListener("click", () => {
        let numberElement = document.getElementById('input');
        let numberElementValue = Number(numberElement.value);
        convert(numberElementValue);
    });

    function convert(numberElementValue) {
        let resultElement = document.getElementById('result');
        let selectedOption = selectMenuToElement.options[selectMenuToElement.selectedIndex].text;
        if (selectedOption == 'Binary') {
            let binaryNumber = 0;
            let rem, i = 1;
            while (numberElementValue != 0) {
                rem = numberElementValue % 2;
                numberElementValue = parseInt(numberElementValue / 2);
                binaryNumber = binaryNumber + rem * i;
                i = i * 10;
            }
            resultElement.value = binaryNumber;
        } else if (selectedOption == 'Hexadecimal') {
            let hexString = numberElementValue.toString(16).toUpperCase();
            resultElement.value = hexString;
        }
    };
}