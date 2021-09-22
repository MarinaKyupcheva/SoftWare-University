function bookList(input){
let pagesInBook = input[0];
let pagesPerHour = input[1];
let days = input[2];
let timeForBook = pagesInBook / pagesPerHour;
let hourPerDay = timeForBook / days;
console.log(hourPerDay);
}

bookList(["212", "20", "2"]);