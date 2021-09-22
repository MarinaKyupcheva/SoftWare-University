function solve() {
let textAreas = document.querySelectorAll('textArea');
let buttons = document.querySelectorAll('button');
let body = document.querySelector('tbody');

buttons[0].addEventListener('click', onClick);

function onClick(e){
const arr = JSON.parse(textAreas[0].value);

for(let el of arr){

  const row = document.createElement('tr');

  const cellImage = document.createElement('td')
  const image = document.createElement('img');
  image.setAttribute('src', el.img);
  cellImage.appendChild(image);

  const cellName = document.createElement('td')
  const name = document.createElement('p');
  name.textContent = el.name;
  cellName.appendChild(name);

  const cellPrice = document.createElement('td');
  const price = document.createElement('p');
  price.textContent = el.price;
  cellPrice.appendChild(price);

  const cellDecFactor = document.createElement('td');
  const decFactor = document.createElement('p');
  decFactor.textContent = el.decFactor;
  cellDecFactor.appendChild(decFactor);

  const cellCheck = document.createElement('td');
  const input = document.createElement('input');
  input.setAttribute('type', 'checkbox');
  cellCheck.appendChild(input);

  row.appendChild(cellImage);
  row.appendChild(cellName);
  row.appendChild(cellPrice);
  row.appendChild(cellDecFactor);
  row.appendChild(cellCheck);

  body.appendChild(row);
}
}

buttons[1].addEventListener('click', solve);

function solve(e){
  const furniture = Array.from(body.querySelectorAll('input[type=checkbox]:checked'))
  .map(input=>input.parentNode.parentNode);

  const result = {
    bought: [],
    totalPrice: 0,
    decFactorSum: 0
  }

  for(let row of furniture){
    const cells = row.children;

    const name = cells[1].children[0].textContent;
    result.bought.push(name);

    const price = Number(cells[2].children[0].textContent);
    result.totalPrice += price;

    const decFactor = Number(cells[3].children[0].textContent);
    result.decFactorSum += decFactor;
  }

  textAreas[1].value = `Bought furniture: ${result.bought.join(', ')}\nTotal price: ${result.totalPrice.toFixed(2)}\nAverage decoration factor: ${result.decFactorSum / furniture.length}`
}
}

