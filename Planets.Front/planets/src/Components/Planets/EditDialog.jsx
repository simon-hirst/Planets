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
    constructor(props) {
        super(props);
        this.state = { open: false }
    }

    handleToggle = () =>{
        this.setState({
            open: !this.state.open
        })
    }

    render(){
        const {open} = this.state

        return <Dialog open={open} onClose={this.handleToggle}>
            <DialogTitle id='form-dialog-title'>
                Editing {name}
            </DialogTitle>
            <DialogContent>

            </DialogContent>
        </Dialog>
    }
    }