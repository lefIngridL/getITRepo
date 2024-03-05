import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'


function Square({ name, value, onSquareClick }) {
    return (
        <button className="square" onClick={onSquareClick}>
            {value}
        </button>
    );
}

function MyMath({ squares, handle }) {
    console.log(squares.length);
    let size = squares.length;
    let root = Math.sqrt(size);

    let Brett = Array(root).fill().map(() => Array());
    function handleme(i) {
        handle(i);
        console.log("reached handleme" + i);
    }
    for (let f = 0; f < size; f++) {
        let choice = calc(f);
        Brett[choice.i].push(<Square key={"key" + f} name={f} value={squares[f]} onSquareClick={() => handleme(f)} />);
    }
    function calc(x) {
        for (let i = 0; i < root; i++) {
            let it = i + 1;
            let from = (it - 1) * root;
            let to = (root * it) - 1;
            //console.log(x+ "fra: " + from + " .Til: " + to);
            if (x >= from && x <= to) {
                console.log(i);
                return { i, from, to };
            }
        }
    }
    console.log(Brett);
    let TheBoard = [];
    Brett.forEach(element => {
        TheBoard.push(<div key={"row-key" + TheBoard.length} className='board-row'>{element}</div>);
    });
    //console.log(TheBoard);
    // ----
    TheBoard.forEach(element => {

        //console.log(element.props.children);
        element.props.children.forEach(ele => {
            console.log(ele.props);
        })
    });
    return <>{TheBoard}</>;
}
function Row({ squares, handle }) {
    //console.log(handle);
    function handleme(i) {
        handle(i);
        //console.log(i);
    }

    const myboard = [[], [], []];
    let it = 0;
    let size = 9;
    let root = Math.sqrt(size);
    let exBoard = Array(root).fill(Array(root));
    //console.log(exBoard);
    exBoard.forEach(ele => {
        ///console.log(ele);
        ele[0] = "FRANZ";
        ele.forEach(lala => {
            ele.fill("HERBERT");
            //console.log(lala);


        })
    });
    for (let a = 0; a < exBoard.length; a++) {
        exBoard[a][1] = "HELEN";
        //console.log(exBoard[a]);
    }
    // 5x5, 25, brett. row 1: 0-4 (4: root-1), row 2: 5-9 (5: root, 9: (root*2)-1), row 3: 10-14 (10: root*2, 14: (root*3)-1), row 4: 15-19 (15: root*3, 19: (root*4)-1), row 5: 20-24 (20: root*4, 24). 
    //console.log(exBoard);
    for (let f = 0; f < size; f++) {
        let root = Math.sqrt(size);
        //console.log(root);
        function choose() {
            if (f < root) {
                return 0;
            }
            else if (f > (root - 1) && f < (root * 2)) {
                return 1;
            }
            else if (f > ((root * 2) - 1) && f < (root * root)) { return 2; }
        }
        let choice = choose();
        myboard[choice].push(<Square key={"key" + f} name={f} value={squares[f]} onSquareClick={() => handleme(f)} />);
    }
    console.log(myboard);
    let TheBoard = [];
    myboard.forEach(element => {
        TheBoard.push(<div key={"row-key" + TheBoard.length} className='board-row'>{element}</div>);
    });
    //console.log(TheBoard);
    // ----
    TheBoard.forEach(element => {

        //console.log(element.props.children);
        element.props.children.forEach(ele => {
            //console.log(ele.props);
        })
    });
    return <>{TheBoard}</>;
}


function Board({ xIsNext, squares, onPlay }) {
    console.log(squares.length);
    function handleClick(i) {
        //console.log(squares);
        //console.log(i);
        if (squares[i] || calculateWinner(squares)) {
            return;
        }
        const nextSquares = squares.slice();
        if (xIsNext) {
            console.log("X");
            nextSquares[i] = "X";
        } else {
            console.log("O");
            nextSquares[i] = "O";
        }

        onPlay(nextSquares);
    }


    const winner = calculateWinner(squares);
    let status;
    if (winner) {
        status = "Winner: " + winner;
    } else {
        status = "Next player: " + (xIsNext ? "X" : "O");
    }
    return (
        <>

            <div key="board-status" className='status'>{status}</div>


            <MyMath squares={squares} handle={handleClick} />
        </>
    );
}
//<Row squares={squares} xIsNext={xIsNext} handle={handleClick} />
export default function Game() {
    let root = 5;
    let size = Math.pow(root, 2);
    const [history, setHistory] = useState([Array(size).fill(null)]);
    const [currentMove, setCurrentMove] = useState(0);
    const xIsNext = currentMove % 2 === 0;
    const currentSquares = history[currentMove];

    function handlePlay(nextSquares) {
        const nextHistory = [...history.slice(0, currentMove + 1), nextSquares];
        setHistory(nextHistory);
        setCurrentMove(nextHistory.length - 1);
    }

    function jumpTo(nextMove) {
        setCurrentMove(nextMove);
    }

    const moves = history.map((squares, move) => {
        let description;
        let element;
        if (move > 0 && move !== currentMove) {
            description = 'Go to move #' + move;
        } else if (move === currentMove) {
            description = 'You are at move#' + move;
        }
        else {
            description = 'Go to game start';
        }
        if (move !== currentMove) {
            element = <button onClick={() => jumpTo(move)}>{description}</button>;
        } else { element = <p>{description}</p>; }
        return (
            <li key={move}>
                {element}
            </li>
        );
    });
    return (
        <div key="game" className='game'>
            <div key="game-board" className='game-board'>
                <Board xIsNext={xIsNext} squares={currentSquares} onPlay={handlePlay} />
            </div>
            <div key="game-info" className='game-info'>
                <ol>{moves}</ol>
            </div>
        </div>
    );
}
function calculateWinner(squares) {
    const lines = [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6]
    ];
    for (let i = 0; i < lines.length; i++) {
        const [a, b, c] = lines[i];
        if (squares[a] && squares[a] === squares[b] && squares[a] === squares[c]) {
            return squares[a];
        }
    }
    return null;
}
//function App() {
//  const [count, setCount] = useState(0)

//  return (
//    <>
//      <div>
//        <a href="https://vitejs.dev" target="_blank">
//          <img src={viteLogo} className="logo" alt="Vite logo" />
//        </a>
//        <a href="https://react.dev" target="_blank">
//          <img src={reactLogo} className="logo react" alt="React logo" />
//        </a>
//      </div>
//      <h1>Vite + React</h1>
//      <div className="card">
//        <button onClick={() => setCount((count) => count + 1)}>
//          count is {count}
//        </button>
//        <p>
//          Edit <code>src/App.jsx</code> and save to test HMR
//        </p>
//      </div>
//      <p className="read-the-docs">
//        Click on the Vite and React logos to learn more
//      </p>
//    </>
//  )
//}

//export default App
