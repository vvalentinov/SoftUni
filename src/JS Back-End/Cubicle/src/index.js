const express = require('express');

const { handlebarsConfig } = require('./config/handlebarsConfig');
const { expressConfig } = require('./config/expressConfig');

const { PORT_NUMBER } = require('./constants/constants');
const routes = require('./routes');
const { dbConfig } = require('./config/dbConfig');

const app = express();

handlebarsConfig(app);
expressConfig(app);

dbConfig()
    .then(() => console.log('Database connected successfully.'))
    .catch(err => console.log(`Error occured: ${err.message}!`));

app.use(routes);

app.listen(PORT_NUMBER, () => console.log(`Server is listening on port ${PORT_NUMBER}...`));