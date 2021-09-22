function radians(input){
let degrees = input[0] * 180/Math.PI;
console.log(`${degrees.toFixed(0)}`);
}

radians(["3.1416"])