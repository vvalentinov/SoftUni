function notify(message) {
  let notificationDivElement = document.getElementById('notification');
  notificationDivElement.style.display = "block";
  notificationDivElement.textContent = message;


  notificationDivElement.addEventListener('click', (e) => {
    e.currentTarget.style.display = "none";
  });
}