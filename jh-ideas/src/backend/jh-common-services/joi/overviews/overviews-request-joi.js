
'use strict';

const joi = require('joi');

const overviewsRequestJoi = joi.object().keys({
  sortBy: joi.string().optional(),
  desc: joi.boolean().default(false).optional(),
  pageNumber: joi.number().integer().min(1).default(1).optional(),
  pageSize: joi.number().integer().min(1).default(20).optional(),
}).optional();

module.exports = overviewsRequestJoi;

