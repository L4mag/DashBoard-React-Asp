import React from 'react';
import getData from '../../logic/Get';

class Boards extends React.Component {
    constructor(props){
        super(props);
        this.state = { boards: ['/a', '/b'] };
    }

    componentDidMount() {
        getData('/home/GetBoards')
            .then(data => {
                console.log(data)
            });
    }

    render() {
        return (
            <div>
                <span>Hello from react!!!</span>
            </div>
        );
    }
}

export default Boards;