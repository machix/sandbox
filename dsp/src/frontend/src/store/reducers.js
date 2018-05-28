import {combineReducers} from 'redux';
import {routerReducer as router} from 'react-router-redux';
import {reducer as reduxAsyncConnect} from 'redux-connect';
import {reducer as form} from 'redux-form';
import {reducer as toastr} from 'react-redux-toastr';
import global from './modules/global';
import searchNFZ from './modules/searchNFZ';

export const makeRootReducer = (asyncReducers) => combineReducers({
  router,
  global,
  searchNFZ,
  form,
  reduxAsyncConnect,
  ...asyncReducers,
  toastr,
});

export const injectReducer = (store, {key, reducer}) => {
  store.asyncReducers[key] = reducer; // eslint-disable-line no-param-reassign
  store.replaceReducer(makeRootReducer(store.asyncReducers));
};

export default makeRootReducer;
