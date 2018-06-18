
'use strict';

const Sequelize = require('sequelize');
const Options = require('../../jh-common-dal/models/entity-options');
const _ = require('lodash');

const IdeaAreaAttributes = {
  ideaId: {
    type: Sequelize.INTEGER,
    allowNull: false,
    primaryKey: true,
  },
  areaId: {
    type: Sequelize.INTEGER,
    allowNull: false,
    primaryKey: true,
  },
};

const IdeaAreaOptions = _.merge(Options, {
  tableName: 'IdeasAreas',
});

module.exports = {
  IdeaAreaAttributes,
  IdeaAreaOptions,
};
