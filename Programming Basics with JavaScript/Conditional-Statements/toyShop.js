function arguments(input){
    let priceOfPuzzle = Number(2.60);
    let priceOfDoll = Number(3);
    let priceOfBear = Number(4.10);
    let priceOfMini = Number(8.20);
    let priceOfTruck = Number(2);

    let priceOfTrip = Number(input[0]);
    let countOfPuzzle = Number(input[1]);
    let countOfDoll = Number(input[2]);
    let countOfBear = Number(input[3]);
    let countOfMinion = Number(input[4]);
    let countOfTruck = Number(input[5]);

    let countOfToys = countOfPuzzle+countOfDoll+countOfBear+countOfMinion+countOfTruck;
    let priceOfToys = (countOfPuzzle*priceOfPuzzle) + (countOfDoll*priceOfDoll) + (countOfBear*priceOfBear) +
     (countOfMinion*priceOfMini) + (countOfTruck*priceOfTruck);
 
   
    if(countOfToys > 50){     
        priceOfToys -= priceOfToys * 0.25;
    }
    let priceOfRent = priceOfToys * 0.10;
    let leftMoney = priceOfToys - priceOfRent;


    if(priceOfToys > priceOfTrip){
        console.log(`Yes! ${(leftMoney - priceOfTrip).toFixed(2)} lv left.`);
    } else{
        console.log(`Not enough money! ${(priceOfTrip - leftMoney).toFixed(2)} lv needed.`);
    }
}
arguments(["40.8", "20", "25","30", "50", "10"]);