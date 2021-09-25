function encodeAndDecodeMessages() {
    let textAreas = document.querySelectorAll('textarea');
    let buttons = document.querySelectorAll('button');

    const map = {
        encode:{
            textArea: textAreas[0],
            button: buttons[0],
            func: (char) => String.fromCharCode(char.charCodeAt(0) + 1)
        },
        decode:{
            textArea: textAreas[1],
            button: buttons[1],
            func: (char) => String.fromCharCode(char.charCodeAt(0) - 1)
        }
    }

    document.getElementById('main').addEventListener('click', onClick);

    function onClick(e){
        if(e.target.tagName !== 'BUTTON'){
            return;
        }

        const type = e.target.textContent.toLowerCase().trim()
        .includes('encode') ? 'encode' : 'decode';

        const message = map[type].textArea.value
        .split('').map(map[type].func).join('');

        map.encode.textArea.value = '';
        map.decode.textArea.value = message;
    }
}