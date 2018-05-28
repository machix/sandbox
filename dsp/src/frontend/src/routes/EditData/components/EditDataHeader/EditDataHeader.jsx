import React from 'react';
import CSSModules from 'react-css-modules';
import styles from './EditDataHeader.scss';

/*
* EditDataHeader
*/

export const EditDataHeader = () => (
  <div styleName="edit-data-header">
    <div styleName="title">Edit Telemetry Data</div>
  </div>
);

EditDataHeader.propTypes = {
};

export default CSSModules(EditDataHeader, styles);
