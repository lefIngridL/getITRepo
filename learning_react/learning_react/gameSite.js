const uri = 'api/Boards';
let boards = [];

function getBoards() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayBoards(data))
        .catch(error => console.error('Unable to get boards.', error));
}

function addBoard() {
    //const addNameTextbox = document.getElementById('add-name');

    const board = {
        isComplete: false,
        name: addNameTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(board)
    })
        .then(response => response.json())
        .then(() => {
            getBoards();
            addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add board.', error));
}

function deleteBoard(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getBoards())
        .catch(error => console.error('Unable to delete board.', error));
}

function displayEditForm(id) {
    const board = boards.find(board => board.id === id);

    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-isComplete').checked = item.isComplete;
    document.getElementById('editForm').style.display = 'block';
}

function updateBoard() {
    const boardId = document.getElementById('edit-id').value;
    const board = {
        id: parseInt(boardId, 10),
        isComplete: document.getElementById('edit-isComplete').checked,
        name: document.getElementById('edit-name').value.trim()
    };

    fetch(`${uri}/${boardId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(board)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update board.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(boardCount) {
    const name = (boardCount === 1) ? 'to-do' : 'to-dos';

    document.getElementById('counter').innerText = `${boardCount} ${name}`;
}

function _displayBoards(data) {

    data.forEach(board => {
        //console.log(board);
        //console.log("is this on?");

    });
    
    boards = data;
    sortBoards();
    updateViewStart();
}

function sortBoards() {
        let b1 = [];
        let b2 = [];
        let b3 = [];
        let b4 = [];
    for (i in boards) {
        switch (boards[i].Size) {
            case 3:
                b1.push(boards[i]);
                break;
            case 5:
                b2.push(boards[i]);
                break;
            case 10:
                b3.push(boards[i]);
                break;
            case 15:
                b4.push(boards[i]);
                break;
        }
    }
    for (i in boards) {
        switch (boards[i].Size) {
            case 3:
                LevelObj.level1.puzzles = b1;
                break;
            case 5:
                LevelObj.level2.puzzles = b2;
                break;
            case 10:
                LevelObj.level3.puzzles = b3;
                break;
            case 15:
                LevelObj.level4.puzzles = b4;
                break;
        }
    }


    }