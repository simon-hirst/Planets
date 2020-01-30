import React, {Component, Fragment} from 'react'
import {
    TextField,
    FormControl,
    InputLabel,
    Select,
    DialogTitle,
    DialogContent,
    Dialog,
    Typography
} from "@material-ui/core";
import Button from "@material-ui/core/Button";
import ErrorDialog from "./ErrorDialog";

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

    componentDidUpdate(prevProps) {
        if (this.props.selectedPlanet !== prevProps.selectedPlanet) {
            this.setState({planet: this.props.selectedPlanet});
        }
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
    }

    render(){
        return(

            <form>
            <Typography display1>
                Editing {this.state.planet.name}
            </Typography>
            <br />
                    <TextField
                        label='Distance from Sun (AU)'
                        value={this.state.planet.distanceFromSun}
                        defaultValue={this.state.planet.distanceFromSun}
                        onChange={this.handleChange('distanceFromSun')}
                    />
                    <br />
                    <TextField
                        label='Diameter (KM)'
                        value={this.state.planet.diameter}
                        defaultValue={this.state.planet.diameter}
                        onChange={this.handleChange('diameter')}
                    />
                    <br />
                    <TextField
                        label='Mass (YG)'
                        value={this.state.planet.mass}
                        defaultValue={this.state.planet.mass}
                        onChange={this.handleChange('mass')}
                    />
                    <br />
                    <Button color='primary' onClick={this.handleSubmit}>
                        Submit
                    </Button>
        </form>
            )
    }
}