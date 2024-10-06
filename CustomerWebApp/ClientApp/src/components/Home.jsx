import React from 'react';
import { connect } from 'react-redux';
import RoomList from './RoomList';

const Home = props => {
  if (props.auth === 0) props.history.push('/');
    return (
        <>
            <RoomList history={props.history} />
         </>        
    );
};

const mapStateToProps = ({ auth }) => {
  return { auth };
};

export default connect(mapStateToProps)(Home);
