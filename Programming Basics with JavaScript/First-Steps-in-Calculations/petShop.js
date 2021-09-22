function countOfPets(input){

    let priceForDogsFood = Number(2.50);
    let priceForOtherFood = Number(4.00);
    let numberOfDogs = Number(input[0]);
    let numberOfOtherAnimals = Number(input[1]);

    let price = (numberOfDogs * priceForDogsFood) + (numberOfOtherAnimals * priceForOtherFood);
    console.log(price);
    
}

countOfPets(["5", "4"]);