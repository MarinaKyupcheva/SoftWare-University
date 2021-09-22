function arguments(input){
let priceOfSrawberriesPerKg = Number(input[0]);
let quantityOfBananas = Number(input[1]);
let quantityOfOringes = Number(input[2]);
let quantityOfRaspberry = Number(input[3]);
let quantityOfStrawberries = Number(input[4]);


let priceForRaspberriesPerKg = priceOfSrawberriesPerKg/2;
let priceForOringesPerKg  = priceForRaspberriesPerKg - (0.4 * priceForRaspberriesPerKg);
let pricePerBananasPerKg  = priceForRaspberriesPerKg - (0.8 * priceForRaspberriesPerKg);

let priceForRasp = priceForRaspberriesPerKg * quantityOfRaspberry;
let priceForOringes = priceForOringesPerKg * quantityOfOringes;
let priceForBananas = pricePerBananasPerKg * quantityOfBananas;
let pricePerStrawberries = priceOfSrawberriesPerKg * quantityOfStrawberries;

let sum = pricePerStrawberries + priceForOringes + priceForRasp + priceForBananas;
console.log(sum);

}

arguments(["48", "10", "3.3", "6.5", "1.7"]);