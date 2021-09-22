function rent(input){
let rentPerDay = Number(input[0]);
let cake = rentPerDay * 20/100;
let drinks =  cake - (cake * 45/100);
let animator = rentPerDay/3;
let sum = rentPerDay + cake + drinks + animator;
console.log(`${sum}`);
}

rent(["2250"]);