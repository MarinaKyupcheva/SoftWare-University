function sumTable() {
let table = document.querySelectorAll('table tr');
let total = 0;

for(let i = 0; i < table.length-1; i++){
    let cols = table[i].children;
    total += Number(cols[cols.length-1].textContent);
  
}

document.getElementById('sum').textContent = total;
}