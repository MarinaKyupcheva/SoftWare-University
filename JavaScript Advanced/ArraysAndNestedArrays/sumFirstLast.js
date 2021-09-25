function arguments(arr){

let firstElement = Number(arr.shift());
let lastElement = Number(arr.pop());
let sum = firstElement + lastElement;
console.log(sum);
}
arguments(['20', '30', '40']);