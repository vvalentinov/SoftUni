function solve() {
  const label = document.querySelector('#info span');
  const departButton = document.getElementById('depart');
  const arriveButton = document.getElementById('arrive');

  let stop = {
    next: 'depot',
  };

  function depart() {
    try {
      fetch(`http://localhost:3030/jsonstore/bus/schedule/${stop.next}`)
        .then((response) => {
          if (response.ok == false) {
            throw new Error('Error');
          }
          return response.json();
        })
        .then((data) => {
          stop = JSON.parse(JSON.stringify(data));
          label.textContent = `Next stop ${data.name}`;
          departButton.disabled = true;
          arriveButton.disabled = false;
        });
    } catch (error) {
      label.textContent = 'Error';
      departButton.disabled = true;
      arriveButton.disabled = true;
    }
  }

  function arrive() {
    label.textContent = `Arriving at ${stop.name}`;
    departButton.disabled = false;
    arriveButton.disabled = true;
  }

  return {
    depart,
    arrive,
  };
}

let result = solve();
