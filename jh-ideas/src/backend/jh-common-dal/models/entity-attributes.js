
'use strict';

const Sequelize = require('sequelize');

const EntityAttributes = {
  id: {
    type: Sequelize.INTEGER,
    autoIncrement: true,
    allowNull: false,
    primaryKey: true,
  },
};

module.exports = {
  EntityAttributes,
};
