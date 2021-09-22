function solve(array){

let max = Number.MIN_SAFE_INTEGER;
let result = array.reduce((acc, curr)=>{
    if(curr >= max){
        max = curr;
        acc.push(curr);
    }
    
    return acc;
}, []);
return result;

//console.log(result.join('\n'));
}

solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]);