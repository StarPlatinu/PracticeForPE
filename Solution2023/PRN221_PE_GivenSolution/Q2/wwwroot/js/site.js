"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/signalRServer")
    .build();

connection.on("LoadOrders", function () {
    location.reload();
});
connection.start().catch(function (err) {
    return console.error(err.toString());
});