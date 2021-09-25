function arguments(steps, meters, speedKmInHour){
let distanceInMeters = steps * meters;
let speedForMeterInSec = speedKmInHour / 3.6;

let rest = Math.floor(distanceInMeters/500);
let timeInSeconds = distanceInMeters / speedForMeterInSec + rest * 60;

let timeInHour = Math.floor(timeInSeconds / 3600);
let timeInMins = Math.floor(timeInSeconds / 60);
let timeInSeconds = Math.ceil(timeInSeconds % 60);

console.log(`${timeInHour < 10 ? 0 : ""}${timeInHour}:${timeInMins < 10 ? 0 : ""}
${timeInMins}:${timeInSeconds < 10 ? 0 : ""}${timeInSeconds}`);

}
arguments(4000, 0.60, 5);