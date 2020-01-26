import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import clsx from 'clsx';
import Card from '@material-ui/core/Card';
import CardHeader from '@material-ui/core/CardHeader';
import CardMedia from '@material-ui/core/CardMedia';
import CardContent from '@material-ui/core/CardContent';
import CardActions from '@material-ui/core/CardActions';
import Collapse from '@material-ui/core/Collapse';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import Button from '@material-ui/core/Button';

const useStyles = makeStyles((theme) => ({
  card: {
    margin: 'auto',
  },
  media: {
    height: 200,
    width: 200,
    margin: 'auto',
  },
  expand: {
    transform: 'rotate(0deg)',
    marginLeft: 'auto',
    transition: theme.transitions.create('transform', {
      duration: theme.transitions.duration.shortest,
    }),
  },
  expandOpen: {
    transform: 'rotate(180deg)',
  },
  header: {
    'text-align': 'center',
  },
  paragraph: {
    'text-align': 'center',
  },
}));

export default function Planet({
  name, image, distanceFromSun, mass, diameter,
}) {
  const classes = useStyles();
  const [expanded, setExpanded] = React.useState(false);
  const imageLocation = `img/${image.toString()}`;

  const handleExpandClick = () => {
    setExpanded(!expanded);
  };

  const handleEditClick = () => {
    setExpanded(!expanded);
  };

  return (
    <Card className={classes.card}>
      <CardHeader
        className={classes.header}
        title={name}
      />
      <CardActions disableSpacing>
        <Button size="small" color="primary" onClick={handleEditClick}>
          Edit
        </Button>
        <IconButton
          className={clsx(classes.expand, {
            [classes.expandOpen]: expanded,
          })}
          onClick={handleExpandClick}
        >
          <ExpandMoreIcon />
        </IconButton>
      </CardActions>
      <Collapse in={expanded} timeout="auto" unmountOnExit>
        <CardContent>
          <CardMedia
            className={classes.media}
            image={imageLocation}
            title={name}
          />
          <Typography paragraph className={classes.paragraph}>
              Distance from the Sun:
            {' '}
            {distanceFromSun}
          </Typography>
          <Typography paragraph className={classes.paragraph}>
              Mass:
            {' '}
            {mass}
          </Typography>
          <Typography paragraph className={classes.paragraph}>
              Diameter:
            {' '}
            {diameter}
          </Typography>
        </CardContent>
      </Collapse>
    </Card>
  );
}
