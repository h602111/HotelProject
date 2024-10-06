import { LOG_IN, LOG_OUT, GET_ROOMS, BOOK_ROOM, GET_BOOKED_ROOMS  } from './types';
import axios from 'axios';

export const login = (user, history) => async dispatch => {
  const res = await axios.post('api/login', user);
  dispatch({
      type: LOG_IN,
      payload: res.data.usernr
  });
  history.push('/home');
};

export const logout = () => async dispatch => {
  dispatch({
    type: LOG_OUT
  });
};

export const getRooms = () => async dispatch => {
    const res = await axios.get('api/home');
    dispatch({
        type: GET_ROOMS,
        payload: res.data
  });
};

export const bookRoom = (room, usernr) => async dispatch => {
    const res = await axios.post('api/reservation', { roomnr: room.roomnr, usernr });
    dispatch({
        type: BOOK_ROOM,
        payload: res.data
  });
};

export const getBookedRooms = usernr => async dispatch => {
    const res = await axios.get(`api/reservation/${usernr}`);
    dispatch({
        type: GET_BOOKED_ROOMS,
        payload: res.data
    });
};
