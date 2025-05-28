function Event(name, date, seats) {
  this.name = name;
  this.date = date;
  this.seats = seats;
}

Event.prototype.checkAvailability = function() {
  return this.seats > 0;
};

const event1 = new Event("Music Fest", "2025-06-15", 50);

console.log(Object.entries(event1)); // keys and values
