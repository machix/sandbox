
'use strict';

const joi = require('joi');
const models = require('../../../jh-ideas-dal/models');

const Idea = models.Idea;
const Status = models.Status;

// getOverviews.schema = {
// };
function* getOverviews() {
  return yield Idea.findAll({
    raw: true, // plain JSON object
    attributes: [
      'id',
      'name',
      'createdDate',
      'description',
    ],
    include: [{
      model: Status,
      required: true, // true -> INNER JOIN, false -> LEFT OUTER JOIN
      attributes: [['name', 'status']],
    }],
  });
}

module.exports = {
  getOverviews,
};
