function solve(arr){
arr.sort((a, b) => a-b);
let result = arr.splice(0, 2);
for (const num of result) {
    console.log(num);
}
}
solve(['30', '15', '50', '5']);