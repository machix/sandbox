
'use strict';

const Sequelize = require('sequelize');

const StatusSchema = {
  id: {
    type: Sequelize.INTEGER,
    autoIncrement: true,
    allowNull: false,
    primaryKey: true,
  },
  name: {
    type: Sequelize.STRING(50),
    allowNull: false,
    unique: true,
  },
};

const StatusConfiguration = {
  timestamps: false,
  tableName: 'Statuses'
};

module.exports = {
  StatusSchema,
  StatusConfiguration,
};
