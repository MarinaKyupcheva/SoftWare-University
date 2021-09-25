function solve(){
   const post = document.querySelector('.site-content main section');
  
   const createButton = document.querySelector('button');
   createButton.addEventListener('click', (e) =>{
      e.preventDefault();

      let author = document.querySelector('#creator');
      let title = document.querySelector('#title');
      let category = document.querySelector('#category');
      let content = document.querySelector('#content');


      let article = document.createElement('article');

      let h1Title = createElement('h1', title.value, undefined);

      let pCategory = createElement('p', 'Category: ', undefined);
      let pStrong = createElement('strong', category.value, undefined);
      pCategory.appendChild(pStrong);

      let pCreator = createElement('p', 'Creator: ', undefined);
      let pStrongAuthor = createElement('strong', author.value, undefined);
      pCreator.appendChild(pStrongAuthor);

      let pContent = createElement('p', content.value, undefined);

      let divButtons = createElement('div', undefined, 'buttons');

      let deleteBtn = createElement('button', 'Delete', 'btn delete');
      deleteBtn.addEventListener('click', () => {
         article.remove();
      });

      let archiveBtn = createElement('button', 'Archive', 'btn archive' );
      
      archiveBtn.addEventListener('click', archiveArticleHandler);
      
     

      article.appendChild(h1Title);
      article.appendChild(pCategory);
      
      article.appendChild(pCreator);
     
      article.appendChild(pContent);
      article.appendChild(divButtons);

      divButtons.appendChild(deleteBtn);
      divButtons.appendChild(archiveBtn);

      post.appendChild(article);

   });

   function archiveArticleHandler(e) {
      let articleToArchive = e.target.parentElement.parentElement;
      let archiveOl = document.querySelector('.archive-section ol');
 
      let archiveLis = Array.from(archiveOl.querySelectorAll('li'));
      let articleTitleHeading = articleToArchive.querySelector('h1');
      let articleTitle = articleTitleHeading.textContent;
 
      let newTitleLi = document.createElement('li');
      newTitleLi.textContent = articleTitle;
 
      articleToArchive.remove();
 
      archiveLis.push(newTitleLi);
      archiveLis
         .sort((a, b) => a.textContent.localeCompare(b.textContent))
         .forEach(li => archiveOl.appendChild(li));
   }

function createElement(type, content, className){
   let result = document.createElement(type);
   result.textContent = content;

   if(className){
      result.className = className;
   }

   return result;
}


}
