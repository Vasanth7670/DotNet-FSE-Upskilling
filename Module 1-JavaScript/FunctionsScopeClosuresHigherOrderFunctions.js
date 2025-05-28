function addEvent(name, date, category) {
  return { name, date, category, seats: 10 };
}

function registerUser(event) {
  if (event.seats > 0) event.seats--;
}

function filterEventsByCategory(events, category) {
  return events.filter((e) => e.category === category);
}

function createCategoryTracker(category) {
  let total = 0;
  return function() {
    total++;
    console.log(`${total} registered in ${category}`);
  };
}

const musicTracker = createCategoryTracker("Music");
musicTracker();
musicTracker();
