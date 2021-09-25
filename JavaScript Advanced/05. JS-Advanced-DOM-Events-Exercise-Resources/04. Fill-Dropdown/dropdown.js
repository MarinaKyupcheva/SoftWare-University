function addItem() {
    let select = document.getElementById('menu');
    let text = document.getElementById('newItemText');
    let val = document.getElementById('newItemValue');
    let option = document.createElement('option');
    
    option.value = val.value;
    option.textContent = text.value;
    if (option.value.length > 0 && option.textContent.length > 0) {
        select.appendChild(option);
    }
    text.value = '';
    val.value = '';

}