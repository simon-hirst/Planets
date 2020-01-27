import React from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import Container from '@material-ui/core/Container';
import Planet from './Planet';

class PlanetContainer extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      planets: [],
      isLoading: true,
      errors: null,
    };
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
      .catch((error) => this.setState({ error, isLoading: false }));
  }

  getPlanet(planetId) {
    let planet;
    axios
      .get(`https://localhost:5001/api/Planet/${planetId}`)
      .then((response) => {
        console.log(response);
        planet = response;
      })
      .catch((error) => this.setState({ error, isLoading: false }));
    return planet;
  }

  putPlanet(){

  }

  updatePlanet(planet) {
    const { planets } = this.state;
    planets[planets.findIndex((x) => x.id === planet.id)] = planet;
    this.setState({ planets });
  }

  componentDidMount() {
    this.getPlanets();
  }

  render() {
    const { isLoading, planets } = this.state;
    return (
      <>
        <Container maxWidth="sm">
          <div>
            {!isLoading ? (
              planets.map((planet) => {
                const {
                  id, name, image, distanceFromSun, mass, diameter,
                } = planet;
                return (
                  <div key={id}>
                    <Planet
                      id={id}
                      name={name}
                      image={image}
                      distanceFromSun={distanceFromSun}
                      mass={mass}
                      diameter={diameter}
                      getPlanet={this.getPlanet}
                      updatePlanet={this.updatePlanet}
                    />
                  </div>
                );
              })
            ) : (
              <p>Loading...</p>
            )}
          </div>
        </Container>
      </>
    );
  }
}

export default PlanetContainer;
