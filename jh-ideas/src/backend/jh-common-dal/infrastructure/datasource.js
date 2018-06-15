'use strict';

const Sequelize = require('sequelize');

module.exports = {
  getDatabase,
};

function getDatabase(connectionOptions) {
  const sequelize = new Sequelize(connectionOptions);
  return sequelize;
}
