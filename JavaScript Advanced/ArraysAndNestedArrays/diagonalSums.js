function solve(arr){
let firstDiagonal = 0;
let secondDiagonal = 0;
let firstIndex = 0;
let secondIndex = arr[0].length-1;

arr.forEach(element => {
    firstDiagonal += element[firstIndex++];
    secondDiagonal += element[secondIndex--];
});

console.log(firstDiagonal + ' ' + secondDiagonal);
}
solve ([[20, 40],
        [10, 60]]);