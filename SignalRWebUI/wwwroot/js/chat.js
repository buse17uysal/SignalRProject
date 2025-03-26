var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:44321/SignalRHub").build();
document.getElementById("sendbutton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours().toString().padStart(2,"0");
    var currentMinute = currentTime.getMinutes().toString().padStart(2, "0");

    var li = document.createElement("li");
    var span = document.createElement("span");
    var time = document.createElement("span");
    span.style.fontWeight = "bold";
    time.style.fontStyle = "italic";
    span.textContent = user;
    time.textContent = `${currentHour}:${currentMinute}`;
    li.appendChild(span);
    li.innerHTML += `:${message}-`;
    li.appendChild(time);
    document.getElementById("messagelist").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendbutton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendbutton").addEventListener("click", function (event) {
    var user = document.getElementById("userinput").value;
    var message = document.getElementById("messageinput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});