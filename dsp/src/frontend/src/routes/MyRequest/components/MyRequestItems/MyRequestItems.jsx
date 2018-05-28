import React, {PropTypes} from 'react';
import CSSModules from 'react-css-modules';
import _ from 'lodash';
import styles from './MyRequestItems.scss';
import RequestItem from '../RequestItem';


class MyRequestItems extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      openedItems: [],
    };
  }

  _toggleDetail(i) {
    if (_.includes(this.state.openedItems, i)) {
      this.state.openedItems.push(i);
    } else {
      this.state.openedItems.splice(this.state.openedItems.indexOf(i), 1);
    }
    this.setState({openedItems: this.state.openedItems});
  }

  render() {
    return (
      <ul>
        {this.props.requestItems.map((requestItem, i) => (
          <RequestItem isOpen={_.includes(this.state.openedItems, i)} _toggleDetail={this._toggleDetail.bind(this)} key={i} index={i} requestItem={requestItem} />
        ))}
      </ul>
    );
  }
}

MyRequestItems.propTypes = {
  requestItems: PropTypes.array.isRequired,
};

export default CSSModules(MyRequestItems, styles);
