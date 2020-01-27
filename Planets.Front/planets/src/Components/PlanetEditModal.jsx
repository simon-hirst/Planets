import React from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

export default function PlanetEditModal({ name, distanceFromSun, mass, diameter }) {
  const [open, setOpen] = React.useState(false);

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  // const handleSubmit = (event) => {
  //     console.log(event.value);
  // };

  // const handleChange = (fieldName) => {
  //     //this.props.fieldName
  // };

  // return (
  //   <div>
  //     <Button variant="outlined" color="primary" onClick={handleClickOpen}>
  //               Edit
  //     </Button>
  //     <Dialog open={open} onClose={handleClose} aria-labelledby="form-dialog-title">
  //       <form onSubmit={handleSubmit}>
  //         <DialogTitle id="form-dialog-title">Editing {name}</DialogTitle>
  //       <DialogContent>
  //         <TextField
  //           autoFocus
  //           margin="dense"
  //           id="name"
  //           label="Name"
  //           type="Name"
  //           fullWidth
  //           onChange={handleChange('name')}
  //         />
  //       </DialogContent>
  //       <DialogActions>
  //         <Button onClick={handleClose} color="primary">
  //                       Cancel
  //         </Button>
  //         <Button onClick={handleSubmit} color="primary">
  //                       Submit
  //         </Button>
  //       </DialogActions>
  //       </form>
  //     </Dialog>
  //   </div>
  // );
}
