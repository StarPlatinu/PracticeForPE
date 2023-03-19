/// <reference path="../../lib/microsoft/signalr/dist/browser/signalr.js" />
"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/signalRServer")
    .build();

connection.on("LoadCourses", function () {
    location.href = '/Movies/Producer_Movie'
});
connection.start().catch(function (err) {
    return console.error(err.toString());
});