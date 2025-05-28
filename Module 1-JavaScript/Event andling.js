document.querySelector("#registerBtn").onclick = () => {
  alert("Registered!");
};

document.querySelector("#categoryFilter").onchange = (e) => {
  console.log("Filter by", e.target.value);
};

document.addEventListener("keydown", (e) => {
  console.log("Searching for:", e.key);
});
