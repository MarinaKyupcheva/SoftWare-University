function solve(matrix){
    let magicSum = Number.MIN_SAFE_INTEGER;
    let isMagicMatrix = true;

for(let row = 0; row < matrix.length; row++) {
    let rowSum = matrix[row].reduce((acc, el) => acc + el);
    if(magicSum === Number.MIN_SAFE_INTEGER){
        magicSum = rowSum;
    }

    if(rowSum !== magicSum){
        isMagicMatrix = false;
    }
}

for(let col = 0; col < matrix[0].length; col++) {
    let colSum = 0;
    for(let row = 0; row < matrix.length; row++){ 
        let colEl = matrix[row][col];
       
        colSum += colEl;
    }

   
    if(colSum !== magicSum){
        isMagicMatrix = false;
    }
}
return isMagicMatrix;
}
console.log(solve([ [4, 5, 6],
        [6, 5, 4],
        [5, 5, 5]]));