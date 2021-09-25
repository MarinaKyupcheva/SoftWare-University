function solve(arr, firstElement, secondElement){
let start = arr.indexOf(firstElement);
let end = arr.indexOf(secondElement);
let result = arr.slice(start, end + 1);
return result;
}
solve (['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie');