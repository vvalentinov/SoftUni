async function attachEvents() {
  let loadPostsButton = document.getElementById('btnLoadPosts');
  let viewPostsButton = document.getElementById('btnViewPost');
  let selectElement = document.getElementById('posts');

  loadPostsButton.addEventListener('click', async () => {
    let data = await fetch('http://localhost:3030/jsonstore/blog/posts').then(
      (response) => {
        return response.json();
      }
    );

    for (const key in data) {
      let optionElement = document.createElement('option');
      optionElement.setAttribute('value', key);
      optionElement.textContent = data[key].title;
      selectElement.appendChild(optionElement);
    }
  });

  viewPostsButton.addEventListener('click', async (e) => {
    let postId = selectElement.value;
    if (postId == '') {
      return;
    }

    let posts = await fetch('http://localhost:3030/jsonstore/blog/posts').then(
      (response) => {
        return response.json();
      }
    );

    let post = posts[postId];

    let h1Element = document.getElementById('post-title');
    h1Element.textContent = post.title;

    let pElement = document.getElementById('post-body');
    pElement.textContent = post.body;

    let commentsData = await fetch(
      'http://localhost:3030/jsonstore/blog/comments'
    ).then((response) => {
      return response.json();
    });

    let comments = [];
    for (const key in commentsData) {
      if (commentsData[key].postId == postId) {
        comments.push(commentsData[key]);
      }
    }

    let ulElement = document.getElementById('post-comments');
    ulElement.innerHTML = '';

    comments.forEach((comment) => {
      let liElement = document.createElement('li');
      liElement.textContent = comment.text;
      ulElement.appendChild(liElement);
    });
  });
}

attachEvents();
