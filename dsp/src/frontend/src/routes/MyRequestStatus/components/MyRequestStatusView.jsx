import React, {PropTypes} from 'react';
import CSSModules from 'react-css-modules';
import Breadcrumb from 'components/Breadcrumb';
import MyRequestHeader from './MyRequestHeader';
import MyRequestTable from './MyRequestTable';
import styles from './MyRequestStatusView.scss';

export const MyRequestStatusView = ({requests, load, filterByStatus}) => (
  <div styleName="my-request-status-view">
    <Breadcrumb
      items={[
        {text: 'Profile', path: '/'},
        {text: 'My Request Status'},
      ]}
    />
    <div styleName="wrap">
      <MyRequestHeader onStatusChange={(value) => load(value)} statusValue={filterByStatus} />
      <div styleName="panel">
        <MyRequestTable requests={requests} />
      </div>
    </div>
  </div>
);

MyRequestStatusView.propTypes = {
  requests: MyRequestTable.propTypes.requests,
  load: PropTypes.func.isRequired,
  filterByStatus: PropTypes.string.isRequired,
};

export default CSSModules(MyRequestStatusView, styles);
