async function solution() {
  let mainSection = document.getElementById('main');

  const data = await fetch(
    'http://localhost:3030/jsonstore/advanced/articles/list'
  ).then((response) => response.json());

  for (let i = 0; i < data.length; i++) {
    const obj = await fetch(
      `http://localhost:3030/jsonstore/advanced/articles/details/${data[i]._id}`
    ).then((response) => response.json());

    let accordionDivElement = document.createElement('div');
    accordionDivElement.className = 'accordion';

    let headDivElement = document.createElement('div');
    headDivElement.className = 'head';

    let spanElement = document.createElement('span');
    spanElement.textContent = obj.title;

    let button = document.createElement('button');
    button.className = 'button';
    button.setAttribute('id', 'ee9823ab-c3e8-4a14-b998-8c22ec246bd3');
    button.textContent = 'More';

    let extraDivClass = document.createElement('div');

    extraDivClass.className = 'extra';

    let pElement = document.createElement('p');
    pElement.textContent = obj.content;

    button.addEventListener('click', (e) => {
      if (e.currentTarget.textContent == 'More') {
        e.currentTarget.textContent = 'Less';
        extraDivClass.style.display = 'inline';
      } else {
        e.currentTarget.textContent = 'More';
        extraDivClass.style.display = 'none';
      }
    });

    headDivElement.appendChild(spanElement);
    headDivElement.appendChild(button);
    extraDivClass.appendChild(pElement);

    accordionDivElement.appendChild(headDivElement);
    accordionDivElement.appendChild(extraDivClass);

    mainSection.appendChild(accordionDivElement);
  }
}

solution();
