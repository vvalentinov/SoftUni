function getArticleGenerator(articles) {
    let divElement = document.getElementById('content');
    let array = articles;
    return function () {
        if (array.length > 0) {
            let article = array[0];
            array.shift();
            let articleElement = document.createElement('article');
            articleElement.textContent = article;
            divElement.appendChild(articleElement);
        }
    }
}