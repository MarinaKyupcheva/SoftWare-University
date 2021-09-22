function solve(arr, rotations){
let reducedRotations = rotations % arr.length;

for (let index = 0; index < reducedRotations; index++) {
    let element = arr.pop();
    arr.unshift(element);
    
}

console.log(arr.join(" "));
}
solve(['1', '2', '3', '4'], 2);