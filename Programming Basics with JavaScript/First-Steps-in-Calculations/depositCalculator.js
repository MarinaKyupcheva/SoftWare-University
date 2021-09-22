function arguments(input){
let depositSum = Number(input[0]);
let month = Number(input[1]);
let annualPercent = Number(input[2]);
let interest = depositSum * annualPercent/100;
let interestForMonth = interest/12;

let sum = depositSum + (month * interestForMonth);
console.log(sum);

}
arguments(["2350", "6", "7"]);