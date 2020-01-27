import React from 'react';
import { render } from 'react-dom';
import PlanetContainer from './PlanetContainer';

const styles = {
  fontFamily: 'sans-serif',
  textAlign: 'center',
};

const App = () => (
  <div style={styles}>
    <PlanetContainer />
  </div>
);

render(<App />, document.getElementById('root'));
