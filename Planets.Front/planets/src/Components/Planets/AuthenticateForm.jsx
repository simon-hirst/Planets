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

export default class AuthenticateForm extends Component {
    constructor(props) {
        super(props);
        this.state = { password: this.props.password };
    }

    handleChange = ({ target : { value }}) => {
        this.setState({
            password : value
        })
    }

    handleSubmit = () => {
        const password = this.state.password;

        this.props.onSubmit({
            password
        })
    }

    render(){
        return(
            <form>
                <Typography display1>
                    Please enter the password.
                </Typography>
                <br />
                <TextField
                    label='Password'
                    value={this.state.password}
                    onChange={this.handleChange}
                />
                <Button color='primary' onClick={this.handleSubmit}>
                    Submit
                </Button>
            </form>
        )
    }
}