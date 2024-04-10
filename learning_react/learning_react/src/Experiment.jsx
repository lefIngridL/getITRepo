import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Draggable from 'react-draggable';

function Box({ mode, id, color, fun, FunEx, sendBox, startBox, Xor }) {
    const [btnValue, setBtnValue] = useState();
    const [colour, setColor] = useState(color);
    const [classColor, setClassColor] = useState("square");
    const [modeX, setModeX] = useState(Xor);


    function funhandle1() {
        let newclass;
        if (color != "white") {
            newclass = color + "Square";
        } else { newclass = "square"; }
        if (!Xor) {
            setClassColor(newclass);
            setBtnValue(null);
        } else {
            setBtnValue("X");
            setClassColor("squareX");
        }
        fun();
        sendBox(id);
    }
    function funhandle2() {
        let newclass;
        if (color != "white") {
            newclass = color + "Square";
        } else { newclass = "square"; }
        if (!Xor) {
            setClassColor(newclass);
            setBtnValue(null);
        } else {
            setBtnValue("X");
            setClassColor("squareX");
        }
        fun();
    }
    function Exfun() {
        FunEx();
    }
    if (mode) {
        return (
            <button className={classColor} key={id} onMouseDown={() => funhandle1()} onMouseEnter={(event) => event.preventDefault()} >{btnValue}</button>
        );
    }
    else if (!mode && startBox[3] === id[3] || startBox[1] === id[1]) {
        return (
            <button className={classColor} key={id} onMouseOver={() => funhandle2()} onMouseUp={() => Exfun()} onMouseEnter={(event) => event.preventDefault()}  >{btnValue}</button>
        );
    } else {
        return (
            <button className={classColor} key={id}>{btnValue}</button>
        );
    }
}
function Row({ keyid, boxArr }) {

    let newId = keyid;
    return (
        <div key={newId}>{boxArr}</div>
    )
}
function Grid({ color, mode, fun, funny, size, Xor }) {
    const [startBox, setStartBox] = useState("x0y0");
    const ArrY = Array(size);
    const ArrX = Array(size);
    for (let i = 0; i < size; i++) {
        ArrY[i] = "y" + i;
        ArrX[i] = "x" + i;
    }


    function funhandle() {

        fun();
    }
    function handleExFun() {
        funny();
    }
    async function getBox(box) {

        setStartBox(box);

    }

    let rowArr = ArrY.map(ele =>
        <Row
            key={"row-" + ele}
            keyid={ele}
            boxArr={ArrX.map(ele2 =>
                <Box
                    mode={mode}
                    key={ele2 + ele}
                    id={ele2 + ele}
                    color={color}
                    fun={funhandle}
                    FunEx={handleExFun}
                    sendBox={getBox}
                    startBox={startBox}
                    Xor={Xor}
                />
            )}
        />);
    //console.log(rowArr);
    return (
        <>


            <div>
                <div>
                    {rowArr}
                </div>
            </div>
        </>
    );
}

function Mode({ color, cap }) {
    function capture() {
        cap();
    }
    return (
        <button className="onOffBtn" onClick={capture}>Color Mode: {color}</button>
    )
}
function ModeX({  cap, xModeStr, xMode }) {
    function capture(x) {
        cap(x);
    }
    return (
        <button className="onOffBtn" onClick={() =>capture(xMode)}>X Mode: {xModeStr}</button>
    )
}
function Window({ mode, children, Endfun }) {

    function funEnd() {
        Endfun();
    }
    if (mode) {
        return (
            <>
                <h3>mode true</h3>

                <div >{children}</div>


            </>

        );
    } else {
        return (
            <>
                <h3>mode false</h3>

                <div onMouseLeave={funEnd}>{children}</div>


            </>
        );
    }
}
function Content() {
    const [mode, setMode] = useState(true);
    const [styleColor, setStyleColor] = useState("blue");
    const [modeStr, setModeStr] = useState("true");
    const [boardSize, setBoardSize] = useState(10);
    const [modeXor, setModeXor] = useState(false);
    const [modeXorStr, setModeXorStr] = useState("false");


    function Receive() {

        if (mode) {
            setMode(false);
            setModeStr("false");
        }
    }
    function funEnd() {
        setMode(true);
        setModeStr("false");

    }
    function Terminate() {
        setMode(true);
        setModeStr("true");
       // console.log("hei");
    }
    function Catch() {
        if (styleColor == "blue") {
            setStyleColor("white");
        } else { setStyleColor("blue"); }
    }
    function CatchX() {
        
        if (modeXor) {
            setModeXor(false);
            setModeXorStr("false");
        } else {
            setModeXor(true);
            setModeXorStr("true");

        }

    }
    return (

        <>
            
            
            <Mode color={styleColor} cap={Catch} />
            <ModeX cap={CatchX} xModeStr={modeXorStr} xMode={modeXor } />
            <Window mode={mode} Endfun={Terminate}>
                <Grid color={styleColor} mode={mode} fun={Receive} funny={funEnd} size={boardSize} Xor={modeXor} />
            </Window >

        </>
    );
}
export default function App() {

    return (
        <>
        <h1>Welcome</h1>
            <Content /></>
        );
}
