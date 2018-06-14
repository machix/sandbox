
'use strict';

/**
 * Category module API's
 *
 */

const Category = require('../models').Category;
const helper = require('../common/helper');

// Exports
module.exports = {
  getAll,
};

/**
 * Get a list of all the drones
 */
function* getAll() {
  const docs = yield Category.find({ });
  return helper.sanitizeArray(docs);
}

