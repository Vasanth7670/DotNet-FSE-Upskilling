function submitForm() {
  fetch("https://jsonplaceholder.typicode.com/posts", {
    method: "POST",
    body: JSON.stringify({ name: "John", email: "john@example.com" }),
    headers: { "Content-type": "application/json; charset=UTF-8" }
  })
    .then((res) => res.json())
    .then((data) => {
      setTimeout(() => alert("Success!"), 1000);
    })
    .catch(() => alert("Failed"));
}
