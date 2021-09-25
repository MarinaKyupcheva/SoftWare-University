function solve(array) {
let object = {};
for (let index = 0; index < array.length; index+=2) {
    let [food] = array[index];
    object[food] = Number(array[index + 1]);    
}
console.log(object);
}
solve (['Yoghurt', '48', 'Rise', '138',
    'Apple', '52']);