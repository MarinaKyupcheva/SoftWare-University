function aggregateElements(elements){

aggregate(elements, 0, (a, b) => a + b);
aggregate(elements, 0, (a, b) => a + 1 / c);
aggregate(elements, '', (a, b) => a + b);

function aggregate(arr, initVal, funk){
    let val = initVal;
    for(let i =0; i < arr.length; i++){
        val = funk(val, arr[i]);
       
    }
    console.log(val);
}
}
aggregateElements([1, 2, 4]);