function solve(arr, step){
let result = [];
arr.forEach((element, i) => {
    if(i % step === 0){
        result.push(element);
    }
});
return result;
}
solve (['6', '20', '1', '4', '20'], 2);