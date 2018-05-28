import {handleActions, createAction} from 'redux-actions';
import Reactable from 'reactable';

const unsafe = Reactable.unsafe;

const rowActions =
  '<ul>' +
    '<li>' +
      '<a href="drone-details">' +
        '<div class="icon-view-detail icon-row"></div>' +
        '<div class="view-detail">View-Detail</div>' +
      '</a>' +
    '</li>' +
    '<li>' +
    '<a href="edit-drones">' +
      '<div class="icon-edit-row icon-row"></div>' +
      '<div class="view-detail">Edit</div>' +
    '</a>' +
    '</li>' +
    '<li>' +
      '<div class="icon-delete-row icon-row"></div>' +
      '<div class="view-detail">Delete</div>' +
    '</li>' +
  '</ul>';
const getImage = () => `${window.location.origin}/img/`;

// ------------------------------------
// Actions
// ------------------------------------
export const itemPerPageAction = createAction('CHANGE_ITEM_SIZE');
export const displayedRowsAction = createAction('DISPLAYED_ROWS');

export const sendRequest = (values) => new Promise((resolve) => {
  alert(JSON.stringify(values, null, 2));
  resolve();
});


export const actions = {
  itemPerPageAction,
  displayedRowsAction,
};

// ------------------------------------
// Reducer
// ------------------------------------
export default handleActions({
  [itemPerPageAction]: (state, action) => ({
    ...state, items: action.payload,
  }),
  [displayedRowsAction]: (state, action) => ({
    ...state, displaying: action.payload,
  }),
}, {
  // initial data
  items: {value: 10, label: '10'},
  displaying: {start: 1, end: 10, currentPage: 0},
  myDrons: [
    {
      lat: -6.195168,
      lng: 106.446533,
      status: 'Stand By',
    },
    {
      lat: -5.145657,
      lng: 104.47998,
      status: 'Booked',
    },
    {
      lat: -7.079088,
      lng: 107.215576,
      status: 'Error',
    },
    {
      lat: -6.500899,
      lng: 107.797852,
      status: 'Stand By',
    },
    {
      lat: -6.937333,
      lng: 108.643799,
      status: 'Booked',
    },
    {
      lat: -7.591218,
      lng: 108.028564,
      status: 'Error',
    },
    {
      lat: -5.462896,
      lng: 107.775879,
      status: 'Error',
    },
  ],
  availableDrones: [
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type gorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type corem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type xorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type sorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type worem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type iorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type korem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type rorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type morem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type gorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type corem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type xorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type sorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type worem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type iorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type korem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type rorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type morem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type gorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type corem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type xorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type sorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type worem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type iorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type korem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type rorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type morem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type gorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type corem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type xorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type sorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type worem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type lorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-2.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type iorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type korem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type rorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type morem', Mileage: '999.99 miles', '': unsafe(rowActions)},

  ],
  onMissionDrones: [
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-1.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type korem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-3.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type rorem', Mileage: '999.99 miles', '': unsafe(rowActions)},
    {Image: unsafe(`<img src="${getImage()}myDrones/my-drone-4.png"/>`), 'Drone Serial Number': '123456789ABC', 'Drone Name': 'Drone name lorem ipsum', 'Drone Type': 'Drone type morem', Mileage: '999.99 miles', '': unsafe(rowActions)},
  ],
});
