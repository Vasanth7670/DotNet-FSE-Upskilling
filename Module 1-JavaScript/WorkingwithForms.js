const form = document.querySelector("#registrationForm");
form.addEventListener("submit", (e) => {
  e.preventDefault();
  const { name, email, event } = form.elements;
  if (!name.value || !email.value) {
    alert("All fields required");
  } else {
    console.log(name.value, email.value, event.value);
  }
});
