// Destructuring & Default Params
function showEvent({ name, date, seats = 10 }) {
  console.log(`Event: ${name}, Date: ${date}, Seats: ${seats}`);
}

const event = { name: "Music Fest", date: "2025-06-15" };
showEvent(event);

// Spread Operator
const newList = [...events];
