import React from 'react';
import { connect } from 'react-redux';
import * as actions from '../store/actions';
import Room from './Room';

class ReservationRoomList extends React.Component {
	componentDidMount = () => {
		this.props.getBookedRooms(this.props.auth);
	}
	render() {
		return (
			<ul className='collection'>
				{this.props.booked.map(room => {
					return <Room key={room.roomnr} room={room} history={this.props.history} />
				})}
			</ul>
		)
	}
}

const mapStateToProps = ({ booked, auth }) => {
	return { booked, auth }
}

export default connect(mapStateToProps, actions)(ReservationRoomList);
