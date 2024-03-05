const uri = 'api/Boards';
let boards = [];

function getBoards() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayBoards(data))
        .catch(error => console.error('Unable to get boards.', error));
}

function idCount() {
    let countId = 1
    for (let i = 0; i < boards.length; i++) {
        if (boards[i].Size == activePuzzle.size) {
            countId++;
        }
    }
    return countId;
}
function addBoard() {
    let id1;
    switch (activePuzzle.size) {
        case 3:
            id1 = 1;
            break;
        case 5:
            id1 = 2;
            break;
        case 10:
            id1 = 3;
            break;
        case 15:
            id1 = 4;
            break;
    }
    let id2 = idCount();
    const board = {
        BoardId: activePuzzle.id,
        Size: activePuzzle.size,
        Rows: activePuzzle.rows,
        Columns: activePuzzle.columns,
        Grid: activePuzzle.grid
    };
    board.BoardId = id1 + "." + id2;
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
            //addNameTextbox.value = '';
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
        console.log("is this on?");
    });
    boards = data;
}