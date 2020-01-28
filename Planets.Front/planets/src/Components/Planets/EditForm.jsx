import React, {Component, Fragment} from 'react'
import {TextField, FormControl, InputLabel, Select, DialogTitle, DialogContent, Dialog} from "@material-ui/core";
import Button from "@material-ui/core/Button";

const styles = theme => ({
    FormControl:{
        width:500
    }
})

export default class EditForm extends Component {
    constructor(props) {
        super(props);
        this.state = { planet: this.props.selectedPlanet, open: false };
    }

    handleChange = name => ({ target : { value }}) => {
        this.setState({
            planet : {
                ...this.state.planet,
                [name] : value
            }
        })
    }

    handleSubmit = () => {
        const planet = this.state.planet;

        this.props.onSubmit({
            planet
        })

        this.setState({
            open: false,
            planet: {
                id: '',
                name: '',
                image: '',
                distanceFromSun: '',
                diameter: '',
                mass: ''
            }
        })
    }

    render(){
        const { name, distanceFromSun, diameter, mass, open } = this.state;

        return(<form>
                    <TextField
                        label='Distance from Sun (AU)'
                        value={distanceFromSun}
                        onChange={this.handleChange('distanceFromSun')}
                    />
                    <br />
                    <TextField
                        label='Diameter (KM)'
                        value={diameter}
                        onChange={this.handleChange('diameter')}
                    />
                    <br />
                    <TextField
                        label='Mass (x10^24KG)'
                        value={mass}
                        onChange={this.handleChange('mass')}
                    />
                    <br />
                    <Button color='primary' raised onClick={this.handleSubmit}>
                        Submit
                    </Button>
        </form>)
    }
}