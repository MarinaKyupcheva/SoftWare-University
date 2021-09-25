function focused() {
   Array.from(document.querySelectorAll('input')).forEach(i => {
    i.addEventListener('focus', onFocus);
    i.addEventListener('blur', onBlur);
   });
    function onFocus(e){
        e.target.parentNode.className = 'focused';
    }
    function onBlur(e){
        e.target.parentNode.className = '';
    }
}