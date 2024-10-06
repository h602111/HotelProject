import React from 'react';
import * as actions from '../store/actions';
import { connect } from 'react-redux';

const Room = props => {
	const handleClick = () => {
		props.bookRoom(props.room, props.auth);
		props.getRooms();
		props.history.push('/home');
	}

	return (
		<li onClick={handleClick} className='collection-item avatar hoverable'>
			<i className='material-icons circle'>photo</i>
			<span className='title'>{props.room.price} kr</span>
			<p>
				Size: {props.room.roomsize} m²<br/>
				Number of beds: {props.room.numberofbeds}
				
			</p>
			<div className='secondary-content black-text'>
				<i className='material-icons'>room</i>Book
			</div>
		</li>
	)
}

const mapStateToProps = ({ auth }) => {
	return { auth };
};

export default connect(mapStateToProps, actions)(Room);
