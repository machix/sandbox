
'use strict';

const Sequelize = require('sequelize');
const _ = require('lodash');

const Op = Sequelize.Op;

function getByKeyword(query, keyword) {
  if (keyword) {
    query = _.merge({
      [Op.or]: [
        {
          '$Idea.name$': {
            [Op.like]: `%${keyword}%`,
          },
        },
        {
          '$Idea.description$': {
            [Op.like]: `%${keyword}%`,
          },
        },
        {
          '$Idea.problemToSolve$': {
            [Op.like]: `%${keyword}%`,
          },
        },
      ],
    }, query);
  }

  return query;
}

function getByStatuses(query, statuses) {
  if (statuses) {
    query = _.merge({
      '$Status.name$': {
        [Op.in]: statuses,
      },
    }, query);
  }

  return query;
}

function getByAreas(query, areas) {
  if (areas) {
    query = _.merge({
      '$[areas->ideaArea].[areaId]$': {
        [Op.in]: areas,
      },
    }, query);
  }

  return query;
}


module.exports = {
  getByKeyword,
  getByStatuses,
  getByAreas,
};
