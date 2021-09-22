function count(input){
let number = Number(input[0]);
let firstBonus = 0;
if(number <= 100){
firstBonus = 5;
} else if(number > 1000){
    firstBonus = number * 0.10;
} else{
    firstBonus = number * 0.20;
}

if(number % 2 === 0){
    firstBonus += 1;
} else if(number % 10 === 5){
    firstBonus += 2;
}
console.log(firstBonus);
console.log(number + firstBonus);
}
count(["20"])