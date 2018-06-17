
'use strict';

const joi = require('joi');
const models = require('../../../jh-ideas-dal/models');
const Sequelize = require('sequelize');
const overviewsRequestJoi = require('../../../jh-common-services/joi/overviews/overviews-request-joi');
const StatusEnum = require('../../../jh-ideas-dal/enums/status');
const _ = require('lodash');

const Idea = models.Idea;
const Status = models.Status;

getOverviews.schema = {
  request: overviewsRequestJoi.keys({
    keyword: joi.string().optional(),
    status: joi.array().items(joi.string().valid(_.values(StatusEnum))).optional(),
    areaIds: joi.array().items(joi.number().integer()).optional(),
    userId: joi.number().integer().optional(),
  }),
};
function* getOverviews(request) {
  return yield Idea.findAll({
    raw: true,
    attributes: [
      'id',
      'name',
      'createdDate',
      'description',
      [Sequelize.col('Status.name'), 'status'],
    ],
    include: [{
      model: Status,
      required: true,
      attributes: [],
    }],
  });
}

module.exports = {
  getOverviews,
};
