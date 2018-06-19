
'use strict';

const joi = require('joi');
const models = require('../../../jh-ideas-dal/models');
const Sequelize = require('sequelize');
const overviewsRequestJoi = require('../../../jh-common-services/joi/overviews/overviews-request-joi');
const StatusEnum = require('../../../jh-ideas-dal/enums/status');
const _ = require('lodash');
const specs = require('../../specifications/idea-specifications');
const joins = require('../../joins/idea-joins');

const Idea = models.Idea;

getOverviews.schema = {
  request: overviewsRequestJoi.keys({
    keyword: joi.string().optional(),
    status: joi.array().items(joi.string().valid(_.values(StatusEnum))).optional(),
    areaIds: joi.array().items(joi.number().integer()).optional(),
    userId: joi.number().integer().optional(),
  }).default({}).optional(),
};
function* getOverviews(request) {
  let include = [];
  include = joins.includeStatus(include);
  include = joins.includeArea(include, request.areaIds);

  let where = {};
  where = specs.getByKeyword(where, request.keyword);
  where = specs.getByStatuses(where, request.status);
  where = specs.getByAreas(where, request.areaIds);

  const overviews = yield Idea.findAll({
    raw: true,
    attributes: [
      'id',
      'name',
      'createdDate',
      'description',
      [Sequelize.col('Status.name'), 'status'],
    ],
    include,
    where,
  });

  return _.map(overviews, overview => _.omit(overview, [
    'areas.ideaArea.ideaId',
    'areas.ideaArea.areaId',
  ]));
}

module.exports = {
  getOverviews,
};
