function addItem() {
let item = document.getElementById('newItemText');
let itemElements = document.getElementById('items');

let liItemelement = document.createElement('li');
liItemelement.textContent = item.value;
itemElements.appendChild(liItemelement);


document.getElementById('newItemText').value = '';
}   