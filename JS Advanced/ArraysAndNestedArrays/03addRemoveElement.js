function solve(arr){
let result = [];
let number = 1;

arr.map(el => {
    el === 'remove' ? result.pop() : result.push(number);
    number++;
})

if(result.length > 0){
    return(result.join("\n"));
} else{
    return('Empty');
}
}
solve('add', 'add', 'add', 'add');