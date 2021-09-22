function password(input){
let pass = "s3cr3t!P@ssw0rd";
let code = input[0];
if(pass === code){
    console.log("Welcome");
}else{
    console.log("Wrong password!");
}
}
password(["qwerty"]);