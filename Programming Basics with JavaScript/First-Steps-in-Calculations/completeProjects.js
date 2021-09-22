function completeProjects(input){

    let timeForOneProct = Number(3);
    let time = timeForOneProct * input[1];
    console.log(`The architect ${input[0]} will need ${time} hours to complete ${input[1]} project/s.`);
}

completeProjects(["George", "4"]);