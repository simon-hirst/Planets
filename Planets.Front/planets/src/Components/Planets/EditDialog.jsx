import React, {Component} from 'react';
import {
    Dialog,
    Button,
    TextField,
    DialogTitle,
    DialogContent,
    DialogContentText,
    DialogActions
} from '@material-ui/core';
import EditForm from "./EditForm";

export default class extends Component{
    state = {
        open: false,
        planet: {
            name: '',
            distanceFromSun: '',
            mass: '',
            diameter: ''
        }
    }

    handleToggle = () =>{
        this.setState({
            open: !this.state.open
        })
    }

    handleChange = name => ({target: {value}}) => {
        this.setState({
            planet: {
                ...this.state.planet
            }
            [name]: value
        })
    }

    handleSubmit = () => {
        const { planet } = this.state;

        this.props.onSubmit({
            ...planet
        })

        this.setState({
            open: false,
            planet: {
                name: '',
                distanceFromSun: '',
                mass: '',
                diameter: ''
            }
        })
    }

    render(){
        const {open, planet:{name, distanceFromSun, mass, diameter}} = this.state,
            { classes } = this.props

        return <Dialog open={open} onClose={this.handleToggle}>
            <DialogTitle id='form-dialog-title'>
                Editing {name}
            </DialogTitle>
            <DialogContent>
                <EditForm

                />
            </DialogContent>
            <DialogActions>
                <Button color='primary' raised onClick={this.handleSubmit}>
                    Submit
                </Button>
            </DialogActions>
        </Dialog>
    }
    }
)