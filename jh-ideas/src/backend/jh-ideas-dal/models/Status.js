
'use strict';

const Sequelize = require('sequelize');
const Attributes = require('../../jh-common-dal/models/entity-attributes');
const Options = require('../../jh-common-dal/models/entity-options');
const _ = require('lodash');

const StatusAttributes = _.merge(Attributes, {
  name: {
    type: Sequelize.STRING(20),
    allowNull: false,
    unique: true,
  },
});

const StatusOptions = _.merge(Options, {
  tableName: 'Statuses'
});

module.exports = {
  StatusAttributes,
  StatusOptions,
};
