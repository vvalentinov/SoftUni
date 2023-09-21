const express = require('express');

const { handlebarsConfig } = require('./config/handlebarsConfig');
const { expressConfig } = require('./config/expressConfig');

const { PORT_NUMBER } = require('./constants/constants');
const routes = require('./routes');

const app = express();

handlebarsConfig(app);
expressConfig(app);

app.use(routes);

app.listen(PORT_NUMBER, () => console.log(`Server is listening on port ${PORT_NUMBER}...`));

