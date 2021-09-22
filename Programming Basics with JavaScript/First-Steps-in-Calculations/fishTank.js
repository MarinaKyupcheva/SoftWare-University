function arguments(input){
let lenght = Number(input[0]);
let width = Number(input[1]);
let height = Number(input[2]);
let percent = Number(input[3]);

let volume = lenght * width * height;
let litters = volume * 0.001;
let percentt = percent * 0.01;
let sumOfLitters = litters *(1-percentt);
console.log(sumOfLitters);
}

arguments(["85", "75", "47", "17"]);