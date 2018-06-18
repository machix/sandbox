
'use strict';

const config = require('config');
const datasourse = require('../../jh-common-dal/infrastructure/datasource');

const database = datasourse.getDatabase(config.Sequelize);

const Area = database.define('area', require('./Area').AreaAttributes, require('./Area').AreaOptions);
const Status = database.define('status', require('./Status').StatusAttributes, require('./Status').StatusOptions);
const Idea = database.define('idea', require('./Idea').IdeaAttributes, require('./Idea').IdeaOptions);
const IdeaArea = database.define('ideaArea', require('./IdeaArea').IdeaAreaAttributes, require('./IdeaArea').IdeaAreaOptions);

Status.hasMany(Idea, { foreignKey: 'statusId', sourceKey: 'id' });
Idea.belongsTo(Status, { foreignKey: 'statusId', targetKey: 'id' });

Idea.belongsToMany(Area, {
  through: IdeaArea,
  foreignKey: 'ideaId',
  otherKey: 'areaId',
});
Area.belongsToMany(Idea, {
  through: IdeaArea,
  foreignKey: 'areaId',
  otherKey: 'ideaId',
});

module.exports = {
  Status,
  Idea,
  Area,
  IdeaArea,
};
