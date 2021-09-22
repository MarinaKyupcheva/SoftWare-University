function solve(n, m){
    let num1 = Number(n);
    let num2 = Number(m);
    let result;
    for (let index = num1; index <= num2; index++) {
        result+=index;
        
    }
    return result;
//console.log(result);
}
solve('1', '5');