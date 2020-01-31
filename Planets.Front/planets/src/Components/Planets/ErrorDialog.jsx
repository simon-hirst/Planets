import React, { Component } from 'react';
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

export default class ErrorDialog extends Component {
  constructor(props) {
    super(props);
    this.state = { open: false };
  }

  render() {
    return (
      <>
        <Dialog
          open={this.props.errors.length}
          onClose={this.props.handleClose}
        >
          <DialogTitle>Error</DialogTitle>
          <DialogContent>
            { Array.isArray(this.props.errors) ? this.props.errors.map((error) => (
                <DialogContentText>
                    {error}
                </DialogContentText>
            )) :  <DialogContentText>
                {this.props.errors}
            </DialogContentText>}
          </DialogContent>
          <DialogActions>
            <Button onClick={this.props.handleClose} color="primary">
                            OK
            </Button>
          </DialogActions>
        </Dialog>
      </>
    );
  }
}
