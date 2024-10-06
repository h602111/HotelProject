import 'materialize-css/dist/css/materialize.min.css';
import 'materialize-css/dist/js/materialize.min.js';
import './index.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { createBrowserHistory } from 'history';
import { Provider } from 'react-redux';
import { ConnectedRouter } from 'connected-react-router';
import configureStore from './store/reducers'
import App from './components/App';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const history = createBrowserHistory({ basename: baseUrl });
const store = configureStore(history);

ReactDOM.render(
    <Provider store={store}>
       <ConnectedRouter history={history}>
           <App />
        </ConnectedRouter>
    </Provider>,
    document.getElementById('root')
);