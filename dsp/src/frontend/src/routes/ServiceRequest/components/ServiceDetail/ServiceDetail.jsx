import React, {PropTypes} from 'react';
import CSSModules from 'react-css-modules';
import Button from 'components/Button';
import {reduxForm} from 'redux-form';
import Location from '../Location';
import ItemRequest from '../ItemRequest';
import Zones from '../Zones';
import ContactDetails from '../ContactDetails';
import EstimatedAmountToPay from '../EstimatedAmountToPay';
import styles from './ServiceDetail.scss';


/*
* ServiceDetail
*/

export const ServiceDetail = ({fields, handleSubmit, startLocation, endLocation, resetForm, zones, ...rest}) => (
  <div>
    <form onSubmit={handleSubmit} styleName="service-detail">
      <div styleName="locations">
        <Location type="red" address={startLocation} />
        <Location type="green" address={endLocation} />
      </div>
      {/* locations end */}
      <div styleName="data">
        <Zones {...rest} zones={zones} styles={null} />
        <ItemRequest fields={fields} />
        <ContactDetails fields={fields} />
        <EstimatedAmountToPay fields={fields} />
      </div>
      {/* data end */}
      <div styleName="actions">
        <Button color="gray" onClick={resetForm} className={styles.btnMargin}>Cancel</Button>
        <Button type="submit" color="blue">Send Request</Button>
      </div>
      {/* actions end */}
    </form>
  </div>
);

ServiceDetail.propTypes = {
  fields: PropTypes.object.isRequired,
  zones: PropTypes.array.isRequired,
  startLocation: PropTypes.object.isRequired,
  endLocation: PropTypes.object.isRequired,
  handleSubmit: PropTypes.func.isRequired,
  resetForm: PropTypes.func.isRequired,
};


const fields = ['name', 'date', 'worth', 'weight', 'dimension', 'hazardous', 'sampleField1', 'sampleField2'];

const validate = (values) => {
  const errors = {};
  if (!values.name) {
    errors.name = 'required';
  }
  if (!values.date) {
    errors.date = 'required';
  }
  if (!values.worth) {
    errors.worth = 'required';
  }
  if (!values.weight) {
    errors.weight = 'required';
  }
  if (!values.dimension) {
    errors.dimension = 'required';
  }
  return errors;
};

export default reduxForm({form: 'serviceRequest', fields, validate})(CSSModules(ServiceDetail, styles));
