
'use strict';

const joi = require('joi');
const models = require('../../../jh-ideas-dal/models');
const Sequelize = require('sequelize');
const overviewsRequestJoi = require('../../../jh-common-services/joi/overviews/overviews-request-joi');
const StatusEnum = require('../../../jh-ideas-dal/enums/status');
const _ = require('lodash');
const specifications = require('../../specifications/idea-specifications');

const Idea = models.Idea;
const Status = models.Status;
const Area = models.Area;
const IdeaArea = models.IdeaArea;

getOverviews.schema = {
  request: overviewsRequestJoi.keys({
    keyword: joi.string().optional(),
    status: joi.array().items(joi.string().valid(_.values(StatusEnum))).optional(),
    areaIds: joi.array().items(joi.number().integer()).optional(),
    userId: joi.number().integer().optional(),
  }).default({}).optional(),
};
function* getOverviews(request) {
  let where = {};
  where = specifications.getByKeyword(where, request.keyword);
  where = specifications.getByStatuses(where, request.status);
  where = specifications.getByAreas(where, request.areaIds);

  const overviews = yield Idea.findAll({
    raw: true,
    attributes: [
      'id',
      'name',
      'createdDate',
      'description',
      [Sequelize.col('Status.name'), 'status'],
    ],
    include: [
      {
        model: Status,
        required: true,
        attributes: [],
      },
      {
        model: Area,
        through: {
          model: IdeaArea,
          required: true,
          attributes: [],
        },
        required: true,
        attributes: [],
      },
    ],
    where,
  });

  return _.map(overviews, (overview) => {
    return _.omit(overview, [
      'areas.ideaArea.ideaId',
      'areas.ideaArea.areaId',
    ]);
  });
}

module.exports = {
  getOverviews,
};
