import React, { Component } from 'react';
import { Route } from 'react-router';
import Boards from './components/boards/Boards';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Boards/>
    );
  }
}
