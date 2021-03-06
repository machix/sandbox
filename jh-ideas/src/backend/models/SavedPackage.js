
'use strict';

/**
 * The SavedPackage model
 *
 */

const mongoose = require('../datasource').getMongoose();
const timestamps = require('mongoose-timestamp');
const helper = require('../common/helper');

const Schema = mongoose.Schema;

const SavedPackageSchema = new mongoose.Schema({
  package: { type: Schema.Types.ObjectId, required: true, ref: 'Package' },
  user: { type: Schema.Types.ObjectId, required: true, ref: 'User' },
  provider: { type: Schema.Types.ObjectId, required: true, ref: 'Provider' },
});

SavedPackageSchema.plugin(timestamps);

helper.sanitizeSchema(SavedPackageSchema);

module.exports = {
  SavedPackageSchema,
};
