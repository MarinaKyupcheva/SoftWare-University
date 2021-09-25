function solve() {
    let openSection = document.getElementsByTagName('section')[1];
    let inProgressSection = document.getElementsByTagName('section')[2];
    let completeSection = document.getElementsByTagName('section')[3];

    const addButton = document.querySelector('button');
    addButton.addEventListener('click', (ev) => {
        ev.preventDefault();

        const task = document.getElementById('task');
        const description = document.getElementById('description');
        const date = document.getElementById('date');

        

        if(task.value === "" || description.value === "" || date.value === ""){
            return;
        }

        let article = document.createElement('article');
        let h3 = e('h3', task.value);
        //h3.textContent = task.value;
        let p1 = e('p', `Description: ${description.value}`)
        let p2 = e('p', `Due Date: ${date.value}`)

        let div = e('div', undefined, 'flex');
        //div.className = 'flex';
        let btnStart = e('button', 'Start', 'green');
        let btnDelete = e('button', 'Delete', 'red');
        let btnFinish = e('button', 'Finish', 'orange');

        btnDelete.addEventListener('click', () => {
            article.remove();
        });

        btnStart.addEventListener('click', () => {
          /*      
        article.lastElementChild.children[0].remove();
        article.lastElementChild.appendChild(btnFinish);
        inProgressSection.lastElementChild.appendChild(article);
        */
        inProgressSection.children[1].appendChild(article);
            btnStart.remove();
            div.appendChild(btnFinish);

        btnFinish.addEventListener('click', () =>{
        
        article.lastElementChild.remove();
        completeSection.lastElementChild.appendChild(article);

        });
        
        });
        div.appendChild(btnStart);
        div.appendChild(btnDelete);
        article.appendChild(h3);
        article.appendChild(p1);
        article.appendChild(p2);
        article.appendChild(div);

        

        openSection.lastElementChild.appendChild(article);

        task.value = '';
        description.value = '';
        date.value = '';

        function e(type, content, className){
            const result = document.createElement(type);
            result.textContent = content;
            if(className){
                result.className = className;
            }
        
            return result;
        }
    });

    
}
