import React, { Fragment } from 'react';
import {
  Grid, Paper, Typography, List, ListItem, ListItemText, Avatar, ListItemSecondaryAction, IconButton,
} from '@material-ui/core';
import { Edit } from '@material-ui/icons';
import EditForm from './EditForm';

const styles = {
  Paper: { padding: 20, marginTop: 10, marginBottom: 10 },
  Paragraph: {

  },
};

export default ({
  planets, onSelect, selectedPlanet, onEdit, editingPlanet, onSubmit,
}) => (
  <Grid container>
    <Grid item sm>
      <Paper style={styles.Paper}>
        {planets
          ? (
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
          )
          : null}
      </Paper>
    </Grid>
    <Grid item sm>
      <Paper style={styles.Paper}>
        {
              editingPlanet ? <EditForm selectedPlanet={selectedPlanet} onSubmit={onSubmit}/>
                : (
                  <>
                    <Typography display1>
                      {selectedPlanet.name}
                    </Typography>
                    <Avatar style={{ width: '100px', height: '100px' }} src={`img/${selectedPlanet.image}`} />
                    <Typography subheading style={{ marginTop: 20 }}>
              Mass
                    </Typography>
                    <Typography paragraph style={{ marginTop: 20 }}>
                      {selectedPlanet.mass}
                    </Typography>
                    <Typography subheading style={{ marginTop: 20 }}>
              Distance from Sun
                    </Typography>
                    <Typography paragraph style={{ marginTop: 20 }}>
                      {selectedPlanet.distanceFromSun}
                    </Typography>
                    <Typography subheading style={{ marginTop: 20 }}>
              Diameter
                    </Typography>
                    <Typography paragraph style={{ marginTop: 20 }}>
                      {selectedPlanet.diameter}
                    </Typography>
                  </>
                )
          }
      </Paper>
    </Grid>
  </Grid>
);
