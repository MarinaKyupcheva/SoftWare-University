function search() {
   let listOfItems = document.querySelectorAll('#towns>li');
   let input = document.querySelector('input').value;
   let result = document.getElementById('result');

   let sum = 0;

   for (const town of listOfItems) {
      if((town.textContent).toLowerCase().includes(input.toLowerCase())){
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         sum++;
      } else{
         town.style.fontWeight = '';
         town.style.textDecoration = '';
      }
      
   }
   result.textContent = `${sum} matches found`;
}
