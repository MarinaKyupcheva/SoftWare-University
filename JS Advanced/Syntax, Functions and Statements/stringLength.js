function arguments(arr1, arr2, arr3){
    let sumLength = arr1.length + arr2.length + arr3.length;
    let avrLength = sumLength / 3;
    console.log(sumLength);
    console.log(Math.floor(avrLength));
}

arguments('chocolate', 'ice cream', 'cake');