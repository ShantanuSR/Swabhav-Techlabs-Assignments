const form = document.getElementById("form");
const dateInput = document.getElementById("date"); 

const activityContainer = document.getElementById("activity-container");
const addActivityButton = document.getElementById("add-activity");

let ActivityIndex = 0; 

addActivityButton.addEventListener("click", function () {
    const newActivityForm = document.createElement("div");
    newActivityForm.classList.add("activity-form"); 
    newActivityForm.setAttribute("data-index", ActivityIndex); 
    newActivityForm.innerHTML = `
        <h3>Activity ${ActivityIndex + 1}</h3>
        <label for="project-name-${ActivityIndex}">Enter Project Name:</label>
        <select id="project-name-${ActivityIndex}">
            <option value="Lending">Finance</option>
            <option value="Banking">Banking</option>
        </select>

        <label for="sub-project-${ActivityIndex}">Enter Sub-project Name:</label>
        <select id="sub-project-${ActivityIndex}">
            <option value="lending-sub">finance sub</option>
            <option value="banking-sub">banking sub</option>
        </select>

        <label for="batch-${ActivityIndex}">Enter Batch:</label>
        <select id="batch-${ActivityIndex}">
            <option value="Apro Captive">Apro Captive</option>
            <option value="Apro Payments">Apro Payments</option>
        </select>

        <div>
          <label for="hours-needed-${ActivityIndex}">Hours Needed:</label>
          <input type="number" id="hours-needed-${ActivityIndex}" />
        </div>

        <div>
          <label for="activity-${ActivityIndex}">Activity:</label>
          <textarea id="activity-${ActivityIndex}"></textarea>
        </div>
         <button type="button" class="remove-activity" data-index="${ActivityIndex}">Cancel Activity</button>
        
    `;
    activityContainer.appendChild(newActivityForm);
    ActivityIndex++; 
});

const showTimesheetButton = document.getElementById("showData");

showTimesheetButton.addEventListener("click", function () {
    fetch("http://localhost:5140/api/TimeSheet")
        .then((response) => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            return response.json();
        })
        .then((data) => {
            displayTimesheet(data);
        })
        .catch((error) => {
            console.error("Error fetching timesheet data:", error);
        });
});

function displayTimesheet(data) {
    const tableContainer = document.createElement("div");
    tableContainer.innerHTML = `
      <div class="container">
        <h3>Previous Timesheet Entries</h3>
        <table class="table table-bordered">
          <thead>
            <tr>
            <th>Sr.No</th>
            <th>Date</th>
              <th>On Leave</th>
              <th>Project</th>
              <th>Sub-project</th>
              <th>Batch</th>
              <th>Hours Needed</th>
              <th>Activity</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
             ${data.map((entry, entryIndex) =>
        entry.TimeSheetsList.map((activity, activityIndex) => `
                <tr>
                  <td>${entryIndex + 1}.${activityIndex + 1}</td>
                  <td>${entry.todaysDate}</td>
                  <td>${entry.onLeave ? "Yes" : "No"}</td>
                  <td>${activity.project}</td>
                  <td>${activity.subProject}</td>
                  <td>${activity.batch}</td>
                  <td>${activity.hoursNeeded}</td>
                  <td>${activity.activityDone}</td>
                  <td>
                    <button class="btn btn-danger" onclick="deleteEntry(${entry.dateId})">Delete</button>
                  </td>
                </tr>
              `).join('')
    ).join('')}
          </tbody>
        </table>
      </div>
    `;

    const existingTable = document.querySelector(".table");
    if (existingTable) {
        existingTable.remove(); // Remove existing table if present
    }

    document.body.appendChild(tableContainer); // Append table to body or a specific container
}

showTimesheetButton.addEventListener("click", function () {
    console.log("Show Data button clicked"); // Debugging line
    fetch("http://localhost:5140/api/TimeSheet")
        .then((response) => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            return response.json();
        })
        .then((data) => {
            displayTimesheet(data);
        })
        .catch((error) => {
            console.error("Error fetching timesheet data:", error);
        });
});


activityContainer.addEventListener("click", function (event) {
    if (event.target.classList.contains("remove-activity")) {
        const indexToRemove = event.target.getAttribute("data-index");
        const activityToRemove = document.querySelector(`.activity-form[data-index="${indexToRemove}"]`);
        activityToRemove.remove(); // Remove the activity
        ActivityIndex--
    }
});


form.addEventListener("submit", async function (event) {
    event.preventDefault();

    const date = dateInput.value;

    // Check for selected radio button
    const onLeaveInput = document.querySelector('input[name="on-leave"]:checked');
    if (!onLeaveInput) {
        console.error("On leave input not found.");
        return; // Exit early if no selection
    }
    const onLeave = onLeaveInput.value === "true";

    const activityForms = document.querySelectorAll(".activity-form");
    const activities = Array.from(activityForms).map((form, index) => ({
        timesheetId: 0,
        project: form.querySelector(`#project-name-${index}`).value,
        subProject: form.querySelector(`#sub-project-${index}`).value,
        batch: form.querySelector(`#batch-${index}`).value,
        hours: parseInt(form.querySelector(`#hours-needed-${index}`).value, 10),
        activity: form.querySelector(`#activity-${index}`).value
    }));

    const data = {
        dateId: 0,
        dateInfo: date,
        onLeave: onLeave,
        timeSheetsList: activities
    };

    try {
        const response = await fetch("http://localhost:5140/api/Timesheet", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(data)
        });

        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.message || "Something went wrong");
        }

        const result = await response.json();
        console.log("Successfully posted:", result);
        alert("Timesheet submitted successfully!");
        form.reset();
        activityContainer.innerHTML = "";
        ActivityIndex = 0;
    } catch (error) {
        console.error("Error:", error.message);
    }
});


function deleteEntry(id) {
    fetch(`http://localhost:5140/api/TimeSheet/${id}`, {
        method: "DELETE",
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            alert("Entry deleted successfully");
            showTimesheetButton.click();
        })
        .catch((error) => {
            console.error("Error deleting entry:", error);
        });
}