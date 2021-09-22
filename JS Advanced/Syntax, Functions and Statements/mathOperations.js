function operation(arr1, arr2, arr3){
let result;

switch(arr3){
    case '+': result = arr1 + arr2; break;
    case '-': result = arr1 - arr2; break;
    case '*': result = arr1 * arr2; break;
    case '/': result = arr1 / arr2; break;
    case '%': result = arr1 % arr2; break;
    case '**': result = arr1 ** arr2; break;
}
console.log(result);
}
operation(5, 6, '+');