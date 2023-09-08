function solution() {
    const addGiftButton = document.querySelectorAll('button')[0];

    addGiftButton.addEventListener('click', addGift);

    function addGift(){
        const sentGiftsUlElement = document.querySelectorAll('ul')[1];
        const discardGiftsUlElement = document.querySelectorAll('ul')[2];
        let input = document.querySelector('input');
        let gift = input.value;
        input.value = '';

        let ulElement = document.querySelectorAll('ul')[0];
        let listGifts = Array.from(ulElement.children);
        ulElement.innerHTML = '';

        let liElement = document.createElement('li');
        liElement.className = 'gift';
        liElement.textContent = gift;

        let sendButton = document.createElement('button');
        sendButton.textContent = 'Send';
        sendButton.setAttribute('id', 'sendButton');
        sendButton.addEventListener('click', () => append(sentGiftsUlElement));
        liElement.appendChild(sendButton);

        let discardButton = document.createElement('button');
        discardButton.textContent = 'Discard';
        discardButton.setAttribute('id', 'discardButton');
        discardButton.addEventListener('click', () => append(discardGiftsUlElement))
        liElement.appendChild(discardButton);

        listGifts.push(liElement);
        listGifts = listGifts.sort((a, b) => a.textContent.localeCompare(b.textContent));
        listGifts.forEach(liElement => ulElement.appendChild(liElement));

        function append(ulElement) {
            const li = document.createElement('li');
            li.textContent = gift;
            ulElement.appendChild(li);
            liElement.remove();
        }
    }
}