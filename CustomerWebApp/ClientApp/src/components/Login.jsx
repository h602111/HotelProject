import React from 'react';
import { connect } from 'react-redux';
import * as actions from '../store/actions';

class Login extends React.Component {
    state = { email: '', password: '' };

    componentDidMount = () => {
        if (this.props.auth !== 0) this.props.history.push('/home');
    }

  handleChange = e => {
    this.setState({
      [e.target.id]: e.target.value
    });
  };

  handleSubmit = e => {
    e.preventDefault();
    this.props.login(this.state, this.props.history);
  };

  render() {
    return (
      <>
        <div className='container'>
          <form onSubmit={this.handleSubmit} className='white'>
            <h5 className='grey-text text-darken-3'>Sign In</h5>
            <div className='input-field'>
              <i className='material-icons prefix'>email</i>
              <label htmlFor='email'>Email</label>
              <input
                type='text'
                id='email'
                maxLength='100'
                onChange={this.handleChange}
              />
            </div>
            <div className='input-field'>
              <i className='material-icons prefix'>lock</i>
              <label htmlFor='password'>Password</label>
              <input
                type='password'
                maxLength='100'
                id='password'
                onChange={this.handleChange}
              />
            </div>
            <button
              className={`btn grey z-depth-0 right ${
                !this.state.email || !this.state.password ? 'disabled' : ''
              }`}>
              Log In
            </button>
          </form>
        </div>
      </>
    );
  }
}

const mapStateToProps = ({ auth }) => {
  return { auth };
};

export default connect(mapStateToProps, actions)(Login);
