const events = [
  { name: "Music Fest", date: "2025-06-15", seats: 5 },
  { name: "Tech Talk", date: "2024-05-20", seats: 0 },
  { name: "Art Expo", date: "2025-07-01", seats: 10 }
];

const today = new Date("2025-05-26");

events.forEach((event) => {
  const eventDate = new Date(event.date);
  if (eventDate > today && event.seats > 0) {
    console.log(`Upcoming: ${event.name}`);
  } else {
    console.log(`Not available: ${event.name}`);
  }
});

function register(event) {
  try {
    if (event.seats > 0) {
      event.seats--;
      console.log(`Registered for ${event.name}`);
    } else {
      throw new Error("No seats left!");
    }
  } catch (err) {
    console.error(err.message);
  }
}
