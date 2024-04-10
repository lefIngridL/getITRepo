import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'


function Box({ id, fun, color }) {
    const [colour, setColor] = useState(color);
    const [classColor, setClassColor] = useState("square");
    const [funOn, setFunOn] = useState(() => ON);

    function ON() {
        console.log("ON");
        return "ON";
    }
    function funhandle() {
        console.log("fun handled");
        let newclass = color + "Square";
        setClassColor(newclass);
        fun();
        let lalal = () => funOn;
    }
    return (
        <td className={classColor} key={id} onMouseOver={() => funhandle()} ></td>
    )
}

function Grid({ fun, color }) {
    let idArr = ["key6", "key7", "key8", "key9", "key10"];
    function funhandle() {
        console.log("handling fun");
        fun();
    }
    let boxArr = idArr.map(ele => <Box key={ele} id={ele} fun={funhandle} color={color} />);
    let rowArr = idArr.map(ele => <tr key={ele}>{boxArr}</tr>)
    return (
        <>

            <h3>Table?</h3>
            <table>
                <tbody>
                    {rowArr}
                </tbody>
            </table>
        </>
    );
}


export default function App() {
    const [useClick, setUseClick] = useState(true);
    const [mode, setMode] = useState(true)
    const handleClick = () => {
        alert('Clicked!');
    };

    const handleMouseOver = () => {
        alert('Mouse over!');
    };
    const [activeFun, setFun] = useState(reds());
    const [styleColor, setStyleColor] = useState("blue");
    function reds() {
        console.log("RED");

    }
    if (mode) {
        return (
            <>
                <p>testing 123</p>
                <Grid fun={reds} color={styleColor} />

            </>

        );
    }

}