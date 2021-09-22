function meters(input){
let priceForMeter = Number(7.61);
let metersGrrening = priceForMeter * input[0];
let percentOfDiscaunt = Number(0.18);
let discount = metersGrrening * percentOfDiscaunt;
let finalPrice = metersGrrening - discount;
console.log(`The final price is: ${finalPrice} lv.`);
console.log(`The discount is: ${discount} lv.`);
}

meters(["550"]);