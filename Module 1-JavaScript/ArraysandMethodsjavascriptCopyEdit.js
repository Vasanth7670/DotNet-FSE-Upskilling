const events = [];

events.push({ name: "Music Fest", category: "Music" });
events.push({ name: "Art Expo", category: "Art" });

const musicEvents = events.filter((e) => e.category === "Music");
console.log(musicEvents);

const eventCards = events.map((e) => `Event: ${e.name}`);
console.log(eventCards);
