
'use strict';

/**
 * The Question model
 *
 */

const mongoose = require('../datasource').getMongoose();
const helper = require('../common/helper');

const QuestionSchema = new mongoose.Schema({
  text: { type: String, required: true },
});

helper.sanitizeSchema(QuestionSchema);

module.exports = {
  QuestionSchema,
};
