function solve() {
  let sections = Array.from(document.querySelectorAll('section'));

  let answers = [];
  for (let index = 0; index < sections.length; index++) {
    const currentSection = sections[index];
    const currentULElement = currentSection.children[0];
    const currentLIElements = Array.from(currentULElement.children);

    const firstAnswer = currentLIElements[1].children[0].children[0];
    const secondAnswer = currentLIElements[2].children[0].children[0];

    firstAnswer.addEventListener('click', clickMe);
    secondAnswer.addEventListener('click', clickMe);

    function clickMe(e) {
      currentSection.style.display = 'none';
      if (index + 1 < sections.length) {
        sections[index + 1].style.display = 'block';
      }
      answers.push(e.currentTarget.textContent);
      if (index === 2) {
        let countRight = 0;
        if (answers[0] == 'onclick') {
          countRight++;
        }
        if (answers[1] == 'JSON.stringify()') {
          countRight++;
        }
        if (answers[2] == 'A programming API for HTML and XML documents') {
          countRight++;
        }

        const resultsElement = document.getElementById('results');
        resultsElement.style.display = 'block';

        const liElement = resultsElement.children[0];
        const h1Element = liElement.children[0];

        if (countRight === 3) {
          h1Element.textContent = 'You are recognized as top JavaScript fan!';
        } else {
          h1Element.textContent = `You have ${countRight} right answers`;
        }
      }
    }
  }
}
