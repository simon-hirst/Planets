import React, { Component } from 'react';
import axios from 'axios';
import { Page } from './Layouts';
import Planets from './Planets';
import { planets } from '../store.js';

export default class extends Component {
  constructor(props) {
    super(props);
    this.state = { planets: [], isLoading: true, error: '', selectedPlanet: {}, editingPlanet: false };
  }

  componentDidMount() {
    this.getPlanets();
  }

  getPlanets(){
    axios
      .get('https://localhost:5001/api/Planet')
      .then((response) => {
        this.setState({
          planets: response.data,
          isLoading: false,
        });
      })
      .catch((error) => this.setState({ error, isLoading: false }));
  }

  handlePlanetSelected = id => {
    this.setState(( { planets } ) => ({
      selectedPlanet: planets.find(planet => planet.id === id)
    }))
  }

  handleEditPlanet = id => {
    this.setState(( { planets } ) => ({
      selectedPlanet: planets.find(planet => planet.id === id),
      editingPlanet: true
    }))
  }

  render() {


    return (
      <>
        <Page />
        <Planets selectedPlanet={this.state.selectedPlanet} planets={this.state.planets}
                 onSelect={this.handlePlanetSelected} onEdit={this.handleEditPlanet}
                 editingPlanet={this.state.editingPlanet}/>
      </>
    );
  }
}
