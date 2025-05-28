const eventsContainer = document.querySelector("#eventsContainer");

const eventDiv = document.createElement("div");
eventDiv.textContent = "Music Fest - June 15";
eventsContainer.appendChild(eventDiv);

function updateUI(event) {
  eventDiv.textContent = `${event.name} - Seats left: ${event.seats}`;
}
