
// Function to create a row and append it to the table
function addTodoToTable(todo) {
    const todosTable = document.getElementById('todosTable');
    const newRow = todosTable.insertRow();
    
    const cell1 = newRow.insertCell(0);
    const cell2 = newRow.insertCell(1);
    const cell3 = newRow.insertCell(2);
    const cell4 = newRow.insertCell(3);
    const cell5 = newRow.insertCell(4); // Cell for delete button

    // Fill the cells with todo data
    cell1.innerHTML = todo.id;
    cell2.innerHTML = todo.userId;
    cell3.innerHTML = todo.title;
    cell4.innerHTML = todo.completed ? 'True' : 'False';

    // Create and append delete button
    const deleteButton = document.createElement('button');
    deleteButton.textContent = 'Delete';
    deleteButton.className = 'btn btn-danger btn-sm';
    deleteButton.onclick = () => {
        todosTable.deleteRow(newRow.rowIndex - 1);
        updateRecordCount();
    };
    cell5.appendChild(deleteButton);

    updateRecordCount();
}

async function fetchTodos() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/todos');
        const data = await response.json();

        const todosTable = document.getElementById('todosTable');
        todosTable.innerHTML = ''; // Clear existing table

        // Use the reusable function to add each fetched todo
        data.forEach(todo => addTodoToTable(todo));
    } catch (error) {
        console.error('Error fetching todos:', error);
    }
}

function updateRecordCount() {
    document.getElementById('recordCount').textContent = document.getElementById('todosTable').rows.length;
}

window.onload = fetchTodos;

document.getElementById('todoForm').addEventListener('submit', function (e) {
    e.preventDefault();

    const userId = document.getElementById('userId').value;
    const title = document.getElementById('title').value;
    const completed = document.getElementById('completed').value.toLowerCase() === 'true';

    // Create a new todo object
    const newTodo = {
        id: document.getElementById('todosTable').rows.length + 1,
        userId,
        title,
        completed
    };

    // Use the reusable function to add the new todo to the table
    addTodoToTable(newTodo);

    document.getElementById('todoForm').reset(); // Reset form after submission
});
