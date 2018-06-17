
'use strict';

const IdeasService = require('../../../jh-ideas-services/services/ideas/IdeasService');
const helper = require('../../../common/helper');

function* getOverviews(req, res) {
  yield helper.splitQueryToArray(req.query, 'status');
  const overviews = yield IdeasService.getOverviews(req.query);
  return res.json(overviews);
}

module.exports = {
  getOverviews,
};

