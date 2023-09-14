const http = require('http');
const routes = require('./routes/mainRouter');

const port = 5001;

const server = http.createServer((req, res) => routes.forEach(async route => await route(req, res)));

server.listen(port, () => console.log(`Server is listening on port ${port}...`));