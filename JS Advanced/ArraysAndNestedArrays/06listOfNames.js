function solve(array){
let result = array.sort((a,b) => a.localeCompare(b));
let output = result.map(function (item, index) {
    let item_number = index + 1;
    return item_number + "." + item;
}).join('\n');
console.log(output);
}
solve(['John',
    'Bob',
    'Christina',
    'Ema']);