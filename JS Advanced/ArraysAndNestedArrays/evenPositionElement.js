function numbers(input){
let evenPosition = '';
for (let i = 0; i < input.length; i+=2) {
   evenPosition += input[i];
   evenPosition += ' ';   
}
console.log(evenPosition);
}
numbers(['20', '30', '40', '50', '60']);
