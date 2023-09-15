const http = require('http');
const routes = require('./routers/mainRouter');

const port = 5002;

const server = http.createServer((req, res) => routes.forEach(async route => await route(req, res)));

server.listen(port, () => console.log(`Server is listening on port ${port}...`));