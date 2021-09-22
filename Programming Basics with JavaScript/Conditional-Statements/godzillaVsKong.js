function movie(input){
let budget = Number(input[0]);
let people = Number(input[1]);
let priceForOnePerson = Number(input[2]);

let decor = budget * 0.10;
if(people > 150){
    priceForOnePerson = priceForOnePerson *0.90;
}

let sumForPeople = priceForOnePerson * people;

let sum = sumForPeople + decor;
let left = budget - sum;


if(sum > budget){
    console.log('Not enough money!');
    console.log(`Wingard needs ${(sum-budget).toFixed(2)} leva more.`);
} else{
    console.log("Action!");
    console.log(`Wingard starts filming with ${left.toFixed(2)} leva left.`);
}
}
movie (["9587.88",
"222",
"55.68"]);