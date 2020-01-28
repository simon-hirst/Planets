import React from 'react'
import {TextField, FormControl, InputLabel, Select} from "@material-ui/core";

const styles = theme => ({
    FormControl:{
        width:500
    }
})

export default class extends Component {
    render(){
        <form>
            <TextField
                label='Title'
                value={title}
                onChange={this.handleChange('title')}
            />
            <br />
        </form>
    }
}