const express = require('express');

const { handlebarsConfig } = require('./config/handlebarsConfig');
const { expressConfig } = require('./config/expressConfig');

const routes = require('./routes');

const port = 3001;

const app = express();

handlebarsConfig(app);
expressConfig(app);

app.use(routes);

app.listen(port, () => console.log(`Server is listening on port ${port}...`));

