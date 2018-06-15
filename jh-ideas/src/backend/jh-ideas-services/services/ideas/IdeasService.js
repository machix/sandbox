
'use strict';

const joi = require('joi');
const models = require('../../../jh-ideas-dal/models');

const Idea = models.Idea;

// getOverviews.schema = {
// };
function* getOverviews() {
  return yield Idea.findAll();
}

module.exports = {
  getOverviews,
};
