import { Avatar, Typography } from '@material-ui/core';
import React, { Component } from 'react';

export default class PlanetDetailsDisplay extends Component {
  render() {
    const {
      id, name, diameter, distanceFromSun, image, mass,
    } = this.props.planet;

    return (
      <>
        { id
          ? (
            <>
              <Typography display1>
                {name}
              </Typography>
              <Avatar style={{ width: '100px', height: '100px' }} src={`img/${image}`} />
              <Typography subheading style={{ marginTop: 20 }}>
                  Mass
              </Typography>
              <Typography paragraph style={{ marginTop: 20 }}>
                {mass}
                {' '}
                  YG
              </Typography>
              <Typography subheading style={{ marginTop: 20 }}>
                  Distance from Sun
              </Typography>
              <Typography paragraph style={{ marginTop: 20 }}>
                {distanceFromSun}
                {' '}
                  AU
              </Typography>
              <Typography subheading style={{ marginTop: 20 }}>
                  Diameter
              </Typography>
              <Typography paragraph style={{ marginTop: 20 }}>
                {diameter}
                {' '}
                  KM
              </Typography>
            </>
          ) : <></> }
      </>
    );
  }
}
