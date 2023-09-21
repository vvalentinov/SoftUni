const express = require('express');

const port = 3001;

const app = express();

app.get('/', (req, res) => {
    res.send('Hello');
});

app.listen(port, () => console.log(`Server is listening on port ${port}...`));

