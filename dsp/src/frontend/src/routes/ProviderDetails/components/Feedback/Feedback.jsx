import React, {PropTypes} from 'react';
import CSSModules from 'react-css-modules';
import Dropdown from 'react-dropdown';
import styles from './Feedback.scss';
import FeedbackItem from '../FeedbackItem';

const options = [
  {value: 1, label: 'Show 10 reviews'},
  {value: 2, label: 'Show 20 reviews'},
  {value: 3, label: 'Show all reviews'},
];

const defaultOption = options[2];

const Feedback = (props) => (
  <div styleName="feedback-section">
    <div styleName="feedback-header">
      <p>Feedback</p>
      <div styleName="see-reviews-option">

        <Dropdown
          options={options}
          value={defaultOption}
          placeholder=""
        />
      </div>
    </div>

    <div styleName="feedback-items">
      {
        props.feedbacks.map((feedback, i) => (
          <div key={i}><FeedbackItem feedback={feedback} /></div>
        ))
      }
    </div>
  </div>
);

Feedback.propTypes = {
  feedbacks: PropTypes.array.isRequired,
};

export default CSSModules(Feedback, styles);
