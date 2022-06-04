window.addEventListener("load", solve);

function solve() {
  const publishButton = document.getElementById('publish-btn');

  publishButton.addEventListener('click', () => {
    const titleInputElement = document.getElementById('post-title');
    const categoryInputElement = document.getElementById('post-category');
    const contentTextareaElement = document.getElementById('post-content');

    const title = titleInputElement.value;
    const category = categoryInputElement.value;
    const content = contentTextareaElement.value;

    if (title != '' && category != '' && content != '') {
      const reviewListULElement = document.getElementById('review-list');

      const liElement = document.createElement('li');
      liElement.classList.add('rpost');

      const articleElement = document.createElement('article');

      const h4Element = document.createElement('h4');
      h4Element.textContent = title;

      const pCategoryElement = document.createElement('p');
      pCategoryElement.textContent = `Category: ${category}`;

      const pContentElement = document.createElement('p');
      pContentElement.textContent = `Content: ${content}`;

      const editButton = document.createElement('button');
      editButton.classList.add('action-btn');
      editButton.classList.add('edit');
      editButton.textContent = 'Edit';
      editButton.addEventListener('click', () => {
        titleInputElement.value = h4Element.textContent;
        categoryInputElement.value = pCategoryElement.textContent.substring(10);
        contentTextareaElement.value = pContentElement.textContent.substring(9);
        liElement.remove();
      });

      const approveButton = document.createElement('button');
      approveButton.classList.add('action-btn');
      approveButton.classList.add('approve');
      approveButton.textContent = 'Approve';
      approveButton.addEventListener('click', (e) => {
        const publishedListULElement = document.getElementById('published-list');
        e.currentTarget.remove();
        editButton.remove();
        publishedListULElement.appendChild(liElement);
      });

      const clearButton = document.getElementById('clear-btn');
      clearButton.addEventListener('click', () => {
        const publishedListULElement = document.getElementById('published-list');
        publishedListULElement.innerHTML = '';
      });

      articleElement.appendChild(h4Element);
      articleElement.appendChild(pCategoryElement);
      articleElement.appendChild(pContentElement);
      liElement.appendChild(articleElement);
      liElement.appendChild(editButton);
      liElement.appendChild(approveButton);
      reviewListULElement.appendChild(liElement);

      titleInputElement.value = '';
      categoryInputElement.value = '';
      contentTextareaElement.value = '';
    }
  });
}
