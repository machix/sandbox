import React from 'react';
import CSSModules from 'react-css-modules';
import styles from './ServiceRequestView.scss';
import ProviderMapContainer from '../containers/ProviderMapContainer';
import ServiceDetailContainer from '../containers/ServiceDetailContainer';

/*
* ServiceRequestView
*/

export const ServiceRequestView = () => (
  <div>
    <div styleName="service-request-view">
      <div styleName="left-col">
        <ServiceDetailContainer />
      </div>
      <div styleName="right-col">
        <ProviderMapContainer />
      </div>
    </div>
  </div>
);

ServiceRequestView.propTypes = {

};

export default CSSModules(ServiceRequestView, styles);
