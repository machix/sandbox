
'use strict';

const Sequelize = require('sequelize');
const Attributes = require('../../jh-common-dal/models/entity-attributes');
const Options = require('../../jh-common-dal/models/entity-options');
const _ = require('lodash');

const IdeaAttributes = _.merge(Attributes, {
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

const IdeaOptions = _.merge(Options, {
  tableName: 'Ideas'
});

module.exports = {
  IdeaAttributes,
  IdeaOptions,
};
