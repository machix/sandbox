
'use strict';

/**
 * The Category model
 *
 */

const mongoose = require('../datasource').getMongoose();
const timestamps = require('mongoose-timestamp');
const helper = require('../common/helper');

const CategorySchema = new mongoose.Schema({
  name: { type: String, required: true },
});

CategorySchema.plugin(timestamps);

helper.sanitizeSchema(CategorySchema);

module.exports = {
  CategorySchema,
};
