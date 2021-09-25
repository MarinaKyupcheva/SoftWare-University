function numbers(n1, n2, n3){
let largestNumber;
if(n1 > n2 && n1 > n3){
    largestNumber = n1;
} else if(n2 > n1 && n2 > n3){
    largestNumber = n2;
} else if(n3 > n1 && n3 > n2){
    largestNumber = n3;
}

console.log(`The largest number is ${largestNumber}.`);
}
numbers(5, -3, 16);