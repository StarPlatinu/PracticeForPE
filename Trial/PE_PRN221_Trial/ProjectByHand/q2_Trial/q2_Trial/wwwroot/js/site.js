"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/signalRServer")
    .build();
connection.on("LoadEmployees", function () {
    location.href = 'https://localhost:7126/'
});
connection.on("LoadRooms", function () {
    location.href = '/Rooms'
});
connection.start().catch(function (err) {
    return console.error(err.toString());
});