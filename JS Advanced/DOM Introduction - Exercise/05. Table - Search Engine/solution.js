function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let searchFieldElement = document.getElementById('searchField');
      let searchText = searchFieldElement.value.toLowerCase();
      searchFieldElement.value = '';

      let table = document.getElementsByClassName('container')[0];
      let rows = table.rows;
      for (let index = 0; index < rows.length; index++) {
         const row = rows[index];
         row.classList.remove('select');
      }
      for (let index = 1; index <= rows.length - 2; index++) {
         const elements = rows[index].getElementsByTagName('td');
         for (const iterator of elements) {
            if (iterator.textContent.toLowerCase().includes(searchText)) {
               rows[index].classList.add('select');
            }
         }
      }
   }
}