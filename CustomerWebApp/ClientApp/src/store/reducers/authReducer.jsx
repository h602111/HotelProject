import { LOG_IN, LOG_OUT } from '../actions/types';

export default (state = 0, action) => {
    switch (action.type) {
        case LOG_IN:
            return action.payload;
        case LOG_OUT:
            return 0;
        default:
            return state;
    }
};