const handlebars = require('express-handlebars');

exports.handlebarsConfig = (app) => {
    const hbs = handlebars.create({
        helpers: {
            selected(option, value) {
                if (option === value) {
                    return 'selected';
                }
            }
        },
        extname: 'hbs',
    });

    app.engine('hbs', hbs.engine);

    // app.engine('hbs', handlebars.engine({ extname: 'hbs' }));

    app.set('view engine', 'hbs');
    app.set('views', 'src/views');
};