// Fetch using .then()
fetch("https://jsonplaceholder.typicode.com/posts")
  .then((res) => res.json())
  .then((data) => console.log(data))
  .catch((err) => console.error(err));

// Async/Await with spinner
async function loadEvents() {
  document.querySelector("#spinner").style.display = "block";
  try {
    const res = await fetch("https://jsonplaceholder.typicode.com/posts");
    const data = await res.json();
    console.log(data);
  } finally {
    document.querySelector("#spinner").style.display = "none";
  }
}
