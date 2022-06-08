function solve() {
    let recipientNameInputElement = document.getElementById('recipientName');
    let titleInputElement = document.getElementById('title');
    let messageTextareaElement = document.getElementById('message');

    function clearInputs() {
        recipientNameInputElement.value = '';
        titleInputElement.value = '';
        messageTextareaElement.value = '';
    }

    const addToListButton = document.getElementById('add');
    const resetButton = document.getElementById('reset');

    resetButton.addEventListener('click', (e) => {
        e.preventDefault();
        clearInputs();
    })

    addToListButton.addEventListener('click', (e) => {
        e.preventDefault();

        if (recipientNameInputElement.value == '' ||
            titleInputElement.value == '' ||
            messageTextareaElement.value == '') {
            clearInputs();
            return;
        }

        let recipient = recipientNameInputElement.value;
        let title = titleInputElement.value;
        let message = messageTextareaElement.value;

        function appendDeletedMail(element) {
            element.remove();
            let deleteListUlElement = document.getElementsByClassName('delete-list')[0];
            let deletedMailLiElement = document.createElement('li');

            let deletedMailSpanRecipientElement = document.createElement('span');
            deletedMailSpanRecipientElement.textContent = `To: ${recipient}`;

            let deletedMailSpanTitleElement = document.createElement('span');
            deletedMailSpanTitleElement.textContent = `Title: ${title}`;

            deletedMailLiElement.appendChild(deletedMailSpanRecipientElement);
            deletedMailLiElement.appendChild(deletedMailSpanTitleElement);
            deleteListUlElement.appendChild(deletedMailLiElement);
        }

        clearInputs();

        let listULElement = document.getElementById('list');

        let liElement = document.createElement('li');

        let h4TitleElement = document.createElement('h4');
        h4TitleElement.textContent = `Title: ${title}`;

        let h4RecipientElement = document.createElement('h4');
        h4RecipientElement.textContent = `Recipient Name: ${recipient}`;

        let spanElement = document.createElement('span');
        spanElement.textContent = message;

        let listActionDivElement = document.createElement('div');
        listActionDivElement.setAttribute('id', 'list-action');

        let sendButton = document.createElement('button');
        sendButton.textContent = 'Send';
        sendButton.setAttribute('id', 'send');

        sendButton.addEventListener('click', (e) => {
            liElement.remove();

            let sentMailsULElement = document.getElementsByClassName('sent-list')[0];

            let sentMailLiElement = document.createElement('li');

            let recipientSpanSentMailElement = document.createElement('span');
            recipientSpanSentMailElement.textContent = `To: ${recipient}`;

            let titleSpanSentMailElement = document.createElement('span');
            titleSpanSentMailElement.textContent = `Title: ${title}`;

            let divSentMailElement = document.createElement('div');
            divSentMailElement.classList.add('btn');

            let deleteSentMailButton = document.createElement('button');
            deleteSentMailButton.textContent = 'Delete';
            deleteSentMailButton.classList.add('delete');

            deleteSentMailButton.addEventListener('click', () => appendDeletedMail(sentMailLiElement));

            divSentMailElement.appendChild(deleteSentMailButton);

            sentMailLiElement.appendChild(recipientSpanSentMailElement);
            sentMailLiElement.appendChild(titleSpanSentMailElement);
            sentMailLiElement.appendChild(divSentMailElement);
            sentMailsULElement.appendChild(sentMailLiElement);
        });

        let deleteButton = document.createElement('button');
        deleteButton.textContent = 'Delete';
        deleteButton.setAttribute('id', 'delete');

        deleteButton.addEventListener('click', () => appendDeletedMail(liElement));

        listActionDivElement.appendChild(sendButton);
        listActionDivElement.appendChild(deleteButton);

        liElement.appendChild(h4TitleElement);
        liElement.appendChild(h4RecipientElement);
        liElement.appendChild(spanElement);
        liElement.appendChild(listActionDivElement);

        listULElement.appendChild(liElement);
    });
}
solve()