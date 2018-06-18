
'use strict';

const Sequelize = require('sequelize');
const Attributes = require('../../jh-common-dal/models/entity-attributes');
const Options = require('../../jh-common-dal/models/entity-options');
const _ = require('lodash');

const AreaAttributes = _.merge(Attributes, {
  name: {
    type: Sequelize.STRING(50),
    allowNull: false,
    unique: true,
  },
});

const AreaOptions = _.merge(Options, {
  tableName: 'Areas',
});

module.exports = {
  AreaAttributes,
  AreaOptions,
};
