function validate() {
document.getElementById('email').addEventListener('change', onChange);

function onChange(ev){

    console.log('changed');
const email = ev.target.value;

if(/^[a-z]+@[a-z]+\.+[a-z]+$/.test(email)){
    ev.target.classname = '';
} else{
    ev.target.classname = 'error';
}

}
}