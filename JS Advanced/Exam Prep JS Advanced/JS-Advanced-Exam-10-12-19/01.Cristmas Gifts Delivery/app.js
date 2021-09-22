function solution() {
    const [ gifts, sent, discard ] = document.querySelectorAll('section ul');
    const input = document.querySelector('input');
    document.querySelector('button').addEventListener('click', addGift);

    function addGift(){
        const name = input.value;
        input.value = '';

        let element = e('li', name, 'gift');
        let sendBtn = e('button', 'Send', 'sendButton');
        let discardBtn = e('button', 'Discard', 'discardButton');

        element.appendChild(sendBtn);
        element.appendChild(discardBtn);

        sendBtn.addEventListener('click', () => sentGift(name, element));
        discardBtn.addEventListener('click', () => discardGift(name, element));

        gifts.appendChild(element);

        sort();
    }

    function sentGift(name, gift){
        gift.remove();
        let element = e('li', name, 'gift');
        sent.appendChild(element);

    }

    function discardGift(name, gift){
        gift.remove();
        let element = e('li', name, 'gift');
        discard.appendChild(element);
    }

    function sort(){
        Array
        .from(gifts.children)
        .sort((a, b) => a.childNodes[0].textContent.localeCompare(b.childNodes[0].textContent))
        .forEach(g=> gifts.appendChild(g));

    }

    function e(type, content, className){
        const result = document.createElement(type);
        result.textContent = content;
        if(className){
            result.className = className;
        }

        return result;
    }
}