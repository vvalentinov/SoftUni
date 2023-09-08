function solve(){
   let postsSection = document.querySelectorAll('section')[1];

   let createButton = document.getElementsByClassName('btn create')[0];

   let authorInputElement = document.getElementById('creator');
   let titleInputElement = document.getElementById('title');
   let categoryInputElement = document.getElementById('category');
   let contentInputElement = document.getElementById('content');

   function clearInputFields(){
      authorInputElement.value = '';
      titleInputElement.value = '';
      categoryInputElement.value = '';
      contentInputElement.value = '';
   }

   createButton.addEventListener('click', (e) => {
      e.preventDefault();

      let author = authorInputElement.value;
      let title = titleInputElement.value;
      let category = categoryInputElement.value;
      let content = contentInputElement.value;

      clearInputFields();

      let articleElement = document.createElement('article');

      let h1TitleElement = document.createElement('h1');
      h1TitleElement.textContent = title;

      let pCategoryElement = document.createElement('p');
      pCategoryElement.innerHTML = `Category: <strong>${category}</strong>`;

      let pCreatorElement = document.createElement('p');
      pCreatorElement.innerHTML = `Creator: <strong>${author}</strong>`;

      let pContentElement = document.createElement('p');
      pContentElement.textContent = content;

      let buttonsDivElement = document.createElement('div');
      buttonsDivElement.classList.add('buttons');

      let deleteButton = document.createElement('button');
      deleteButton.textContent = 'Delete';
      deleteButton.classList.add('btn');
      deleteButton.classList.add('delete');
      deleteButton.addEventListener('click', (e) => {e.currentTarget.parentNode.parentNode.remove();})
      buttonsDivElement.appendChild(deleteButton);

      let archiveButton = document.createElement('button');
      archiveButton.textContent = 'Archive';
      archiveButton.classList.add('btn');
      archiveButton.classList.add('archive');
      archiveButton.addEventListener('click', (e) => {
         e.currentTarget.parentNode.parentNode.remove();

         let olElement = document.querySelector('ol');

         let liElement = document.createElement('li');
         liElement.textContent = title;

         let liElements = Array.from(olElement.children);
         liElements.push(liElement);
         liElements.sort((a, b) => a.textContent.localeCompare(b.textContent));

         olElement.innerHTML = '';

         liElements.forEach(liElement => {olElement.appendChild(liElement)});
      });

      buttonsDivElement.appendChild(archiveButton);
      articleElement.appendChild(h1TitleElement);
      articleElement.appendChild(pCategoryElement);
      articleElement.appendChild(pCreatorElement);
      articleElement.appendChild(pContentElement);
      articleElement.appendChild(buttonsDivElement);
      postsSection.appendChild(articleElement);
   });
  }
