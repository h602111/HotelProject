import React from 'react';
import { connect } from 'react-redux';
import * as actions from '../store/actions';
import Room from './Room';

class RoomList extends React.Component {
	componentDidMount = () => {
		this.props.getRooms();
	}
	render() {
		return (
				<ul className='collection'>
				{this.props.rooms.map(room => {
					return <Room key={room.roomNr} room={room} history={this.props.history} />
				})}
				</ul>
		)
	}
}

const mapStateToProps = ({ rooms }) => {
	return { rooms }
}

export default connect(mapStateToProps, actions)(RoomList);
