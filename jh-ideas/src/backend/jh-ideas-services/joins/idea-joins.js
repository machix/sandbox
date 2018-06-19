
'use strict';

const models = require('../../jh-ideas-dal/models');

const Status = models.Status;
const Area = models.Area;
const IdeaArea = models.IdeaArea;

function includeStatus(query) {
  query.push({
    model: Status,
    required: true,
    attributes: [],
  });

  return query;
}

function includeArea(query, areaIds) {
  if (areaIds) {
    query.push({
      model: Area,
      through: {
        model: IdeaArea,
        required: true,
        attributes: [],
      },
      required: true,
      attributes: [],
    });
  }

  return query;
}

module.exports = {
  includeStatus,
  includeArea,
};
