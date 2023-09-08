function attachEvents() {
  let conditions = {
    Sunny: '&#x2600;',
    'Partly sunny': '&#x26C5;',
    Overcast: '&#x2601;',
    Rain: '&#x2614;',
    Degrees: '&#176;',
  };

  let submitButton = document.getElementById('submit');

  submitButton.addEventListener('click', () => {
    let inputLocation = document.getElementById('location').value;

    let forecastDivElement = document.getElementById('forecast');
    forecastDivElement.style.display = 'block';

    let currentConditionsDiv = document.getElementById('current');
    let upcomingConditionsDiv = document.getElementById('upcoming');

    let forecastsDivElement = document.createElement('div');
    forecastsDivElement.className = 'forecasts';

    let forecastsInfoDivElement = document.createElement('div');
    forecastsInfoDivElement.className = 'forecast-info';

    fetch('http://localhost:3030/jsonstore/forecaster/locations')
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        let location = data.find((x) => x.name == inputLocation);

        fetch(
          `http://localhost:3030/jsonstore/forecaster/today/${location.code}`
        )
          .then((response) => {
            return response.json();
          })
          .then((data) => {
            forecastsDivElement.innerHTML = `
        <span class='condition symbol'>${
          conditions[data.forecast.condition]
        }</span>
        <span class='condition'>
        <span class='forecast-data'>${data.name}</span>
        <span class='forecast-data'>${data.forecast.low}&#176;/${
              data.forecast.high
            }&#176;</span>
        <span class='forecast-data'>${data.forecast.condition}</span>
        </span>`;
          })
          .catch((err) => {
            console.log(err);
          });

        fetch(
          `http://localhost:3030/jsonstore/forecaster/upcoming/${location.code}`
        )
          .then((response) => {
            return response.json();
          })
          .then((data) => {
            for (let index = 0; index < data.forecast.length; index++) {
              forecastsInfoDivElement.innerHTML += `
            <span class='upcoming'>
            <span class='symbol'>${
              conditions[data.forecast[index].condition]
            }</span>
            <span class='forecast-data'>${data.forecast[index].low}&#176;/${
                data.forecast[index].high
              }&#176;</span>
            <span class='forecast-data'>${data.forecast[index].condition}</span>
            </span>`;
            }
          })
          .catch((err) => {
            console.log(err);
          });

        currentConditionsDiv.appendChild(forecastsDivElement);
        upcomingConditionsDiv.appendChild(forecastsInfoDivElement);
      })
      .catch((err) => {
        console.log(err);
      });
  });
}

attachEvents();
