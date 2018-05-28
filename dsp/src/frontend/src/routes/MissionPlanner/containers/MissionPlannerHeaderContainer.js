import {asyncConnect} from 'redux-connect';
import {actions} from '../modules/MissionPlanner';

import MissionPlannerHeader from '../components/MissionPlannerHeader';

const resolve = [{
  promise: ({params, store}) => store.dispatch(actions.load(params.id)),
}];

const mapState = (state) => state.missionPlanner;

export default asyncConnect(resolve, mapState, actions)(MissionPlannerHeader);
