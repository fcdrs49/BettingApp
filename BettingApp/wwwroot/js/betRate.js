"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/betRateHub", {
    skipNegotiation: true,
    transport: signalR.HttpTransportType.WebSockets
}).build();

connection.on("UpdateBetRates", function (gameId, homeRate, drawRate, awayRate) {
    let elements = document.querySelectorAll(`[data-gameid="${gameId}"]`);
    if (elements != null) {
        elements[0].innerText = homeRate;
        elements[1].innerText = drawRate;
        elements[2].innerText = awayRate;
        let divEl = document.createElement('div');
        divEl.innerText = "Bet rates updated!";
        elements[0].parentElement.parentElement.appendChild(divEl);
        setTimeout(() => {
            elements[0].parentElement.parentElement.removeChild(divEl);
        }, "5000");
    }
});

connection.on("GameFinished", function (gameId, homeTeamGoals, awayTeamGoals) {
    let divToRemove = document.querySelectorAll(`[data-gameid="${gameId}"]`)[0].parentElement;
    if (divToRemove) {
        let divToAppend = document.createElement("div");
        divToAppend.className = "match-result";
        let h1El = document.createElement("h1");
        h1El.className = "score";
        h1El.innerText = `${homeTeamGoals}:${awayTeamGoals}`;
        divToAppend.appendChild(h1El);
        document.querySelectorAll(`[data-detailsgameid="${gameId}"]`)[0].removeChild(divToRemove);
        document.querySelectorAll(`[data-detailsgameid="${gameId}"]`)[0].appendChild(divToAppend);
    }
});

connection.start().then(function () {
    console.log('connection initiated');
}).catch(function (err) {
    return console.error(err.toString())
});
let editBtn = document.getElementById("editBtn");
if (editBtn) {
    editBtn.addEventListener("click", function (event) {
        let gameId = document.getElementById("gameId").value;
        let finished = document.getElementById("gameFinished").checked;
        if (finished) {
            let homeGoals = document.getElementById("homeGoals").value;
            let awayGoals = document.getElementById("awayGoals").value;
            connection.invoke("SetGameFinished", gameId, homeGoals, awayGoals).catch(function (err) {
                return console.error(err.toString());
            })
        } else {
            let homeRate = document.getElementsByClassName("HomeRate")[0].value;
            let drawRate = document.getElementsByClassName("DrawRate")[0].value;
            let awayRate = document.getElementsByClassName("AwayRate")[0].value;
            connection.invoke("UpdateUserBets", gameId, homeRate, drawRate, awayRate).catch(function (err) {
                return console.error(err.toString());
            })
        }
    });
}