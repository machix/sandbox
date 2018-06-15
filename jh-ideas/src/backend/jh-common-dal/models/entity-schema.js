
'use strict';

const Sequelize = require('sequelize');

const EntitySchema = {
  id: {
    type: Sequelize.INTEGER,
    autoIncrement: true,
    allowNull: false,
    primaryKey: true,
  },
};

module.exports = {
  EntitySchema,
};
