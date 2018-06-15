
'use strict';

const Sequelize = require('sequelize');

const IdeaSchema = {
  id: {
    type: Sequelize.INTEGER,
    autoIncrement: true,
    allowNull: false,
    primaryKey: true,
  },
  name: {
    type: Sequelize.STRING(100),
    allowNull: false,
  },
  statusId: {
    type: Sequelize.INTEGER,
    allowNull: false,
    references: {
      model: 'Statuses',
      key: 'id',
    },
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
};

const IdeaConfiguration = {
  timestamps: false,
  tableName: 'Ideas'
};

module.exports = {
  IdeaSchema,
  IdeaConfiguration,
};
