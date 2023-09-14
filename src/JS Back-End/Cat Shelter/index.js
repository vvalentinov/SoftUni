const http = require('http');

const port = 5001;

const server = http.createServer((req, res) => {
    if (req.url == '/') {
        res.write('OK');
        res.end();
    }
});

server.listen(port, () => console.log(`Server is listening on port ${port}...`));