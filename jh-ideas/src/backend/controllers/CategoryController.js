
'use strict';

/**
 * Exposes the API's to manipulate category in the system
 * This includes get a list of all categories
 */

const CategoryService = require('../services/CategoryService');

// Exports
module.exports = {
  getAll,
};

/**
 * Get all categories in the system
 *
 * @param req the request
 * @param res the response
 */
function* getAll(req, res) {
  res.json(yield CategoryService.getAll(req.query));
}
