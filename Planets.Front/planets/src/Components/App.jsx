import React, { Component } from 'react';
import axios from 'axios';
import Planets from './Planets';

export default class extends Component {
  constructor(props) {
    super(props);
    this.state = {
      planets: [], isLoading: true, errors: [], selectedPlanet: {}, editingPlanet: false, password: {}, jwt: {},
    };
  }

  componentDidMount() {
    this.getPlanets();
  }

  getPlanets() {
    axios
      .get('https://localhost:5001/api/Planet')
      .then((response) => {
        this.setState({
          planets: response.data,
          isLoading: false,
        });
      })
      .catch((error) => this.setState({ errors: error, isLoading: false }));
  }

  handlePlanetSelected = id => {
    this.setState(( { planets } ) => ({
      selectedPlanet: planets.find(planet => planet.id === id),
      editingPlanet: false
    }))
  }

  handleEditPlanet = id => {
    this.setState(( { planets } ) => ({
      selectedPlanet: planets.find(planet => planet.id === id),
      editingPlanet: true
    }))
  }

  handleEditSubmit = planet => {
    let config = {
      url: 'https://localhost:5001/api/Planet',
      method : 'put',
      data : planet.planet,
      headers: {
        Authorization: 'Bearer ' + this.state.jwt.token
      }};

    axios
        .request(config)
        .then((response) => {
          this.setState({
            editingPlanet: false,
            planets: [...this.state.planets.filter(p => p.id !== planet.planet.id), planet.planet],
            selectedPlanet: planet.planet
          })
        }).catch((error) => { this.setState({ })});
  }

  handleAuthenticationSubmit = password => {
    axios
        .put('https://localhost:5001/api/Authentication', { Password : password.password } )
        .then((response) => {
          this.setState({
            password: {},
            jwt: response.data
          })
        }).catch((error) => { this.setState({errors: error.response.data })});
  }

  handleErrorDialogClose = () => {
    this.setState({errors: []})
  }

  handleAuthenticateDialogClose = () => {
    this.setState({ authenticating: {}})
  }

  render() {
    return (
      <>
        <Planets
          selectedPlanet={this.state.selectedPlanet}
          planets={this.state.planets}
          onSelect={this.handlePlanetSelected}
          onEdit={this.handleEditPlanet}
          editingPlanet={this.state.editingPlanet}
          onSubmit={this.handleEditSubmit}
          errors={this.state.errors}
          handleErrorDialogClose={this.handleErrorDialogClose}
          handleAuthenticateDialogClose={this.handleAuthenticateDialogClose}
          authenticating={this.state.authenticating}
          onSubmitAuthentication={this.handleAuthenticationSubmit}
          jwt={this.state.jwt}
        />
      </>
    );
  }
}
