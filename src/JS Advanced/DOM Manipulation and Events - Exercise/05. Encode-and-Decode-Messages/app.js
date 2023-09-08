function encodeAndDecodeMessages() {
    let buttonElements = Array.from(document.querySelectorAll('button'));

    let encodeAndSendButtonElement = buttonElements[0];
    let decodeButtonElement = buttonElements[1];

    encodeAndSendButtonElement.addEventListener('click', () => {
        let textAreasElements = Array.from(document.querySelectorAll('textarea'));
        let messageTextArea = textAreasElements[0];
        let decodeMessageTextArea = textAreasElements[1];

        let message = messageTextArea.value;
        messageTextArea.value = '';

        let resultMessage = '';
        for (let index = 0; index < message.length; index++) {
            let char = String.fromCharCode(message.charCodeAt(index) + 1);
            resultMessage += char;
        }

        decodeMessageTextArea.value = resultMessage;
    });

    decodeButtonElement.addEventListener('click', () => {
        let decodeMessageTextarea = Array.from(document.querySelectorAll('textarea'))[1];
        let message = decodeMessageTextarea.value;
        let resultMessage = '';
        for (let index = 0; index < message.length; index++) {
            let char = String.fromCharCode(message.charCodeAt(index) - 1);
            resultMessage += char;
        }

        decodeMessageTextarea.value = resultMessage;
    });
}