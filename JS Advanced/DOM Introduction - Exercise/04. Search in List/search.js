function search() {
   let searchTextElement = document.getElementById('searchText');
   let searchText = searchTextElement.value;

   let resultElement = document.getElementById('result');
   resultElement.textContent = '';

   let matchesCount = 0;
   let townsElements = document.querySelectorAll('li');

   for (let index = 0; index < townsElements.length; index++) {
      const element = townsElements[index];
      element.removeAttribute('style');
      if (element.textContent.includes(searchText)) {
         element.style.fontWeight = 'bold';
         element.style.textDecoration = 'underline';
         matchesCount++;
      }
   }

   resultElement.textContent = `${matchesCount} matches found`;
}
