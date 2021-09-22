function figure(input){
let fig = input[0];
let side = Number(input[1]);
let area = 0;

if(fig === "square"){
let area = side * side;
console.log(area.toFixed(3));

} else if(fig === "rectangle"){
let sideTwo = Number(input[2]);
let area = side * sideTwo;
console.log(area.toFixed(3));

} else if(fig === "circle"){
let area = (side*side) * Math.PI;
console.log(area.toFixed(3));

} else if(fig === "triangle"){
    let sideTwo = Number(input[2]);
    let area = side * sideTwo/2;
    console.log(area.toFixed(3));
}

}
figure(["rectangle", "7", "2.5"]);