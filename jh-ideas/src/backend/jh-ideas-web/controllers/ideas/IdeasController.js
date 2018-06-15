
'use strict';

const IdeasService = require('../../../jh-ideas-services/services/ideas/IdeasService');

function* getOverviews(req, res) {
  const overviews = yield IdeasService.getOverviews(req);
  return res.json(overviews);
}

module.exports = {
  getOverviews,
};

