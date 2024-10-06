import React from 'react';
import { connect } from 'react-redux';
import ReservationRoomList from './ReservationRoomList';

const Reservations = props => {
    if (props.auth === 0) props.history.push('/');
    return (
        <>
            <ReservationRoomList history={props.history} id={props.auth} />
        </>
    );
};

const mapStateToProps = ({ auth }) => {
    return { auth };
};

export default connect(mapStateToProps)(Reservations);