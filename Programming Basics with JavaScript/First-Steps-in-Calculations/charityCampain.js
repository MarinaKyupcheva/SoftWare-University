function arguments(input){
let days = Number(input[0]);
let bakers = Number(input[1]);
let cakes = Number(input[2]);
let waffles = Number(input[3]);
let pancakes = Number(input[4]);

let priceForCake = Number(45.00);
let priceForWaffle = Number(5.80);
let priceForPancake = Number(3.20);

let cakePerDay = priceForCake * cakes;
let wafflesPerDay = priceForWaffle * waffles;
let pancakesPerDay = priceForPancake * pancakes;
let sumPerDays = (cakePerDay + wafflesPerDay + pancakesPerDay) * days;
let sumForBakers = sumPerDays * bakers;

let sumForCharity = sumForBakers - (sumForBakers/8);
console.log(sumForCharity);
}

arguments(["23", "8", "14", "30", "16"]);