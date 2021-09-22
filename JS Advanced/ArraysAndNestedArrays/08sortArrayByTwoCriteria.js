function solve(array){

function compare(current, next){
    if(current.length > next.length){
        return 1;
    } else if(current.length === next.length){
        return current.localeCompare(next);
    } else{
        return -1;
    }
}
array.sort((current, next) => compare(current, next));
console.log(array.join('\n'));

}


solve(['alpha', 'beta', 'gamma']);