import React, { Fragment } from 'react';
import {
  Grid, Paper, Typography, List, ListItem, ListItemText, Avatar, ListItemSecondaryAction, IconButton,
} from '@material-ui/core';
import { Edit } from '@material-ui/icons';
import EditForm from './EditForm';
import PlanetDetailsDisplay from './PlanetDetailsDisplay';
import ErrorDialog from "./ErrorDialog";

const styles = {
  Paper: { padding: 20, marginTop: 10, marginBottom: 10 },
  Container: {
      padding: 25, marginTop: 10, marginBottom: 10
  }
};

export default ({
  planets, onSelect, selectedPlanet, onEdit, editingPlanet, onSubmit, errors, handleErrorDialogClose
}) => (
    <>
    {errors.length ? <ErrorDialog errors={errors} handleClose={handleErrorDialogClose}/> : <></>}

  <Grid container style={styles.Container}>
    <Grid item sm style={styles.Container}>
      <Paper style={styles.Paper}>
        <List component="ul">
          {planets.map((planet) => (
            <ListItem key={planet.id} button onClick={() => onSelect(planet.id)}>
              <ListItemText primary={planet.name} />
              <ListItemSecondaryAction>
                <IconButton onClick={() => onEdit(planet.id)}>
                  <Edit />
                </IconButton>
              </ListItemSecondaryAction>
            </ListItem>
          ))}
        </List>
      </Paper>
    </Grid>
    <Grid item sm style={styles.Container}>
      <Paper style={styles.Paper}>
        {editingPlanet ? <EditForm selectedPlanet={selectedPlanet} onSubmit={onSubmit} errors={errors} handleErrorDialogClose={handleErrorDialogClose} />
          : <PlanetDetailsDisplay planet={selectedPlanet} />}
      </Paper>
    </Grid>
  </Grid>
        </>
);
