import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './app/App';

class HomePage extends React.Component{
  render(){
      return(
          <div>
            <Header title="Test value"/>
              <h1> Home Page</h1>
          </div>
      )
  }
}


class Header extends React.Component{
  render(){
    console.log(this.props)
      return(
          <div>
              <h1>{this.props.title}</h1>
          </div>
      )
  }
}


ReactDOM.render(
  <React.StrictMode>
    <HomePage />
  </React.StrictMode>,
  document.getElementById('root')
);


