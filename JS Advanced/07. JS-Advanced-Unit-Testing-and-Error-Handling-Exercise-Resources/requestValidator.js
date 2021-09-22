function solve(object){

validateMethod(object);
validateUri(object);
validateVersion(object);
validateMessage(object);

return object;

function validateMessage(){
    let propName = 'message';
    let messageRegex = /^[^<>\\&'"]*$/;

    if(object[propName] === undefined || !messageRegex.test(object[propName])){
        throw new Error(`Invalid request header: Invalid Message`);
    }
}

function validateUri(object){
    let propName = 'uri';
    let uriRegex = /^\*$|^[a-zA-z0-9.]+$/;

    if(object[propName] === undefined || !uriRegex.test(object[propName])){
        throw new Error(`Invalid request header: Invalid URI`);
    }
}

function validateVersion(object){
    let propName = 'version';
    let validVersion = ['HTTP/0.9','HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];

    if(object[propName] === undefined || !validVersion.includes(object[propName])){
        throw new Error(`Invalid request header: Invalid Version`);
    }
    }


function validateMethod(object){
    let propName = 'method';
    let validMethod = ['GET', 'POST', 'DELETE', 'CONNECT'];

    if(object[propName] === undefined || !validMethod.includes(object[propName])){
        throw new Error(`Invalid request header: Invalid Method`);
    }
}

} 
try{
    console.log(solve({
        method:'POST',
        uri:'home.bash',
        message:'rm -rf /*'
        }));

}
catch(e){
    console.log(e.message);
}
