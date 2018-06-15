
'use strict';

const config = require('config');
const datasourse = require('../../jh-common-dal/infrastructure/datasource');

const status = require('./Status');
const idea = require('./Idea');

const database = datasourse.getDatabase(config.Sequelize);

const Status = database.define('Statuses', status.StatusSchema, status.StatusConfiguration);
const Idea = database.define('Ideas', idea.IdeaSchema, idea.IdeaConfiguration);

module.exports = {
  Status,
  Idea,
};
