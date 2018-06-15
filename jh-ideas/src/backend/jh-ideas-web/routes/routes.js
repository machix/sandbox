
'use strict';

module.exports = {
  '/ideas': {
    get: {
      controller: 'IdeasController',
      method: 'getOverviews',
    },
  },
};
