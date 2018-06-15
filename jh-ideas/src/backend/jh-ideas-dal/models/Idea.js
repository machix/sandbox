
'use strict';

const Sequelize = require('sequelize');
const Schema = require('../../jh-common-dal/models/entity-schema').EntitySchema;
const Configuration = require('../../jh-common-dal/models/entity-configuration').EntityConfiguration;
const _ = require('lodash');

const IdeaSchema = _.merge(Schema, {
  name: {
    type: Sequelize.STRING(100),
    allowNull: false,
  },
  statusId: {
    type: Sequelize.INTEGER,
    allowNull: false,
  },
  createdDate: {
    type: Sequelize.DATE,
    allowNull: false,
    defaultValue: Sequelize.NOW,
  },
  description: {
    type: Sequelize.TEXT,
    allowNull: false,
  },
  problemToSolve: {
    type: Sequelize.TEXT,
    allowNull: false,
  },
});

const IdeaConfiguration = _.merge(Configuration, {
  tableName: 'Ideas'
});

module.exports = {
  IdeaSchema,
  IdeaConfiguration,
};
