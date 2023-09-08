function attachEventsListeners() {
    let daysBtnElement = document.getElementById('daysBtn');
    let hoursBtnElement = document.getElementById('hoursBtn');
    let minutesBtnElement = document.getElementById('minutesBtn');
    let secondsBtnElement = document.getElementById('secondsBtn');

    daysBtnElement.addEventListener('click', () => {
        let daysInputElement = document.getElementById('days');
        let days = Number(daysInputElement.value);

        let hours = days * 24;
        let minutes = days * 1440;
        let seconds = days * 86400;

        let hoursInputElement = document.getElementById('hours');
        hoursInputElement.value = hours;

        let minutesInputElement = document.getElementById('minutes');
        minutesInputElement.value = minutes;

        let secondsInputElement = document.getElementById('seconds');
        secondsInputElement.value = seconds;
    });

    hoursBtnElement.addEventListener('click', () => {
        let hoursInputElement = document.getElementById('hours');
        let hours = Number(hoursInputElement.value);

        let days = hours / 24;
        let minutes = hours * 60;
        let seconds = hours * 3600;

        let daysInputElement = document.getElementById('days');
        daysInputElement.value = days;

        let minutesInputElement = document.getElementById('minutes');
        minutesInputElement.value = minutes;

        let secondsInputElement = document.getElementById('seconds');
        secondsInputElement.value = seconds;
    });

    minutesBtnElement.addEventListener('click', () => {
        let minutesInputElement = document.getElementById('minutes');
        let minutes = Number(minutesInputElement.value);

        let days = minutes / 1440;
        let hours = minutes / 60;
        let seconds = minutes * 60;

        let daysInputElement = document.getElementById('days');
        daysInputElement.value = days;

        let hoursInputElement = document.getElementById('hours');
        hoursInputElement.value = hours;

        let secondsInputElement = document.getElementById('seconds');
        secondsInputElement.value = seconds;
    });

    secondsBtnElement.addEventListener('click', () => {
        let secondsInputElement = document.getElementById('seconds');
        let seconds = Number(secondsInputElement.value);

        let days = seconds / 86400;
        let hours = seconds / 3600;
        let minutes = seconds / 60;

        let daysInputElement = document.getElementById('days');
        daysInputElement.value = days;

        let hoursInputElement = document.getElementById('hours');
        hoursInputElement.value = hours;

        let minutesInputElement = document.getElementById('minutes');
        minutesInputElement.value = minutes;
    });
}