import React, { Component } from 'react';
import {
  TextField,
  Typography,
} from '@material-ui/core';
import Button from '@material-ui/core/Button';

export default class AuthenticateForm extends Component {
  constructor(props) {
    super(props);
    this.state = { password: this.props.password };
  }

  formPreventDefault = e => {
      e.preventDefault();
      this.handleSubmit();
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

  render() {
    return (
      <form onSubmit={this.formPreventDefault}>
        <Typography display1>
                    Please enter the password.
        </Typography>
        <br />
        <TextField
          label="Password"
          value={this.state.password}
          onChange={this.handleChange}
        />
        <Button color="primary" onClick={this.handleSubmit}>
                    Submit
        </Button>
      </form>
    );
  }
}
