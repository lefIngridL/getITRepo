import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'


function ColorBtn({ change }) {
    return (
        <>
            <button onClick={change}>Annen farge</button>
        </>
    )
}

function Box({ color, BColor }) {
    return (
        <>
            <div style={{ color: color, backgroundColor: BColor, height: 100, width: 100 }}>her</div>
        </>
    )
}

function ranCol() {
    const colorArr = ["red", "blue", "yellow", "black", "magenta", "green"];
    const BColorArr = ["FireBrick", "DarkTurquoise", "DarkGoldenRod", "DarkBlue", "DarkOrchid", "GreenYellow"];
    let ranNum = Math.floor((Math.random() * (colorArr.length - 1)) + 1);
    const style = {
        color: colorArr[ranNum],
        BColor: BColorArr[ranNum]
    }

    return style;
}

function Card({ children }) {
    return (
        <div className="card">
            {children}
        </div>
    )
}
export default function App() {
    const [color, setColor] = useState("white");
    const [bcolor, setBColor] = useState("black");
    function NewColor() {

        let newColor = ranCol().color;
        let newBColor = ranCol().BColor;
        setColor(newColor);
        setBColor(newBColor);
        console.log("old color: " + color + "  ...a new color: " + newColor);
    }
    return (
        <Card>
            <ColorBtn change={NewColor} />
            <Box color={color} BColor={bcolor} />
        </Card>
    )
}