
'use strict';

require('./bootstrap');
const config = require('config');
const express = require('express');
const cors = require('cors');
const bodyParser = require('body-parser');
const _ = require('lodash');
const helper = require('./common/helper');
const errorMiddleware = require('./common/ErrorMiddleware');
const winston = require('winston');

const app = express();
const http = require('http').Server(app);
const io = require('socket.io')(http);

const swaggerUi = require('swagger-ui-express');
const swaggerDocument = require('./swagger.json');

app.set('port', config.PORT);

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));
app.use(cors());
const apiRouter = express.Router();

// include io instance
apiRouter.use((req, res, next) => {
  res.io = io;
  next();
});

io.on('connection', (socket) => { // eslint-disable-line no-unused-vars
  winston.info('socket connection established');
});

// load all routes
const routes = require('./jh-ideas-web/routes/routes');
const dspRoutes = require('./routes');

const controllers = './jh-ideas-web/controllers/';
const dspControllers = './controllers/';
const allControllers = [controllers, dspControllers];

_.each(_.merge(routes, dspRoutes), (verbs, url) => {
  _.each(verbs, (def, verb) => {
    let actions = [
      function (req, res, next) {
        req.signature = def.controller + '#' + def.method;
        next();
      },
    ];

    let method;
    _.each(allControllers, (controller) => {
      if (!method) {
        try {
          method = require(controller + def.controller)[def.method];
        } catch (err) {
          // catch
        }
      }
    });

    if (!method) {
      throw new Error(def.method + ' is undefined, for controller ' + def.controller);
    }
    if (def.middleware && def.middleware.length > 0) {
      actions = actions.concat(def.middleware);
    }
    actions.push(method);
    winston.info(`register ${verb} /api/v${config.API_VERSION}${url}`);
    apiRouter[verb](`/api/v${config.API_VERSION}${url}`, helper.autoWrapExpress(actions));
  });
});

app.use('/', apiRouter);
app.use(errorMiddleware());
app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument));


http.listen(app.get('port'), () => {
  winston.info(`Express server listening on port ${app.get('port')}`);
});

module.exports = app;
