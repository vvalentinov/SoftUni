function attachEventsListeners() {
    const convertButton = document.getElementById('convert');

    convertButton.addEventListener('click', (e) => {
        const inputDistanceElement = document.getElementById('inputDistance');
        let inputDistance = Number(inputDistanceElement.value);

        const inputUnitsSelectElement = document.getElementById('inputUnits');
        const selectedInputUnit = inputUnitsSelectElement.value;

        const outputDistanceSelectElement = document.getElementById('outputUnits');
        const selectedOutputUnit = outputDistanceSelectElement.value;

        // Converting input distance to meters
        switch (selectedInputUnit) {
            case 'km':
                inputDistance *= 1000;
                break;
            case 'cm':
                inputDistance *= 0.01;
                break;
            case 'mm':
                inputDistance *= 0.001;
                break;
            case 'mi':
                inputDistance *= 1609.34;
                break;
            case 'yrd':
                inputDistance *= 0.9144;
                break;
            case 'ft':
                inputDistance *= 0.3048;
                break;
            case 'in':
                inputDistance *= 0.0254;
                break;
        }

        switch (selectedOutputUnit) {
            case 'km':
                inputDistance /= 1000;
                break;
            case 'cm':
                inputDistance *= 100;
                break;
            case 'mm':
                inputDistance *= 1000;
                break;
            case 'mi':
                inputDistance /= 1609.34;
                break;
            case 'yrd':
                inputDistance /= 0.9144;
                break;
            case 'ft':
                inputDistance *= 3.28;
                break;
            case 'in':
                inputDistance *= 39.37;
                break;
        }

        const outputDistanceInputElement = document.getElementById('outputDistance');
        outputDistanceInputElement.value = inputDistance;
    });
}