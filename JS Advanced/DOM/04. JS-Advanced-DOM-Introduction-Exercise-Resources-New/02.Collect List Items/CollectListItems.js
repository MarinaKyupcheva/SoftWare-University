function extractText() {
    let elements = document.querySelectorAll('ul#items li');
    let result = document.querySelector('#result');

    for (const el of elements) {
        result.value += el.textContent += "\n";
    }

}