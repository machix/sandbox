
'use strict';

const Sequelize = require('sequelize');
const Schema = require('../../jh-common-dal/models/entity-schema').EntitySchema;
const Configuration = require('../../jh-common-dal/models/entity-configuration').EntityConfiguration;
const _ = require('lodash');

const StatusSchema = _.merge(Schema, {
  name: {
    type: Sequelize.STRING(50),
    allowNull: false,
    unique: true,
  },
});

const StatusConfiguration = _.merge(Configuration, {
  tableName: 'Statuses'
});

module.exports = {
  StatusSchema,
  StatusConfiguration,
};
