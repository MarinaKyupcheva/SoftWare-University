function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let searchedEl = document.getElementById('searchField');
      let table = Array.from(document.querySelectorAll('.container tbody tr'));

      let searchedText = searchedEl.value;

      table.forEach(row=>{
         row.classname = '';
      });

      let filteredRows = table.filter(row =>{
         let values = Array.from(row.children);
         if(values.some(td=>td.textContent.includes(searchedText))){
            row.className = 'select';
         }
      });

      searchedEl.value = '';

   }
}