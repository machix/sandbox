
'use strict';

const config = require('config');
const datasourse = require('../../jh-common-dal/infrastructure/datasource');

const database = datasourse.getDatabase(config.Sequelize);

const Status = database.define('status', require('./Status').StatusSchema, require('./Status').StatusConfiguration);
const Idea = database.define('idea', require('./Idea').IdeaSchema, require('./Idea').IdeaConfiguration);

Status.hasMany(Idea, { foreignKey: 'statusId', sourceKey: 'id' });
Idea.belongsTo(Status, { foreignKey: 'statusId', targetKey: 'id' });

module.exports = {
  Status,
  Idea,
};
