function colorize() {
    let elements = document.querySelectorAll('table tr');

    for(let i=1; i<= elements.length-1; i+=2){
       let element = elements[i];
        element.style.backgroundColor = 'teal';
    }
}