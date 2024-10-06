import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import * as actions from '../store/actions';

const Navbar = props => {
  return (
    <>
      <nav className='nav-wrapper blue-grey darken-1 z-depth-0'>
        <div style={{ width: '80%' }} className='container'>
          <Link to='/' className='brand-logo center'>
            <i style={{ marginTop: '3%' }} className='large material-icons'>
              hotel
            </i>
            Hotel Project
          </Link>
        {props.auth !== 0 ? (
            <ul id="nav-mobile" className="right">
                <li><Link to="/booked">My Bookings</Link></li>
            </ul>) : null
        }
        </div>
      </nav>
    </>
  );
};

const mapStateToProps = ({ auth }) => {
  return { auth };
};

export default connect(mapStateToProps, actions)(Navbar);
