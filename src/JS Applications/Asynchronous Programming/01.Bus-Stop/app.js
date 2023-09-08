function getInfo() {
  let stopIdElement = document.getElementById('stopId');
  let stopId = stopIdElement.value;
  stopIdElement.value = '';

  let stopNameDivElement = document.getElementById('stopName');

  let busesUlElement = document.getElementById('buses');
  busesUlElement.innerHTML = '';

  const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;

  fetch(url)
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      stopNameDivElement.textContent = data.name;
      for (const key in data.buses) {
        let liElement = document.createElement('li');
        liElement.textContent = `Bus ${key} arrives in ${data.buses[key]} minutes`;
        busesUlElement.appendChild(liElement);
      }
    })
    .catch(() => {
      stopNameDivElement.textContent = 'Error';
    });
}
