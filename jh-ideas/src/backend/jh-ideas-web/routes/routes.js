
'use strict';

module.exports = {
  '/ideas': {
    get: {
      controller: 'ideas/IdeasController',
      method: 'getOverviews',
    },
  },
};
