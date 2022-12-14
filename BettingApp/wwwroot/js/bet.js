$(function () {
    $('.match-bet-option').click(function () {
        $(this).siblings().removeClass('active');
        $(this).toggleClass('active');
        if ($(this).hasClass('active')) {
            $.ajax({
                type: "POST",
                url: "/GameBet/Add",
                data: {
                    __RequestVerificationToken: getToken(),
                    gameId: $(this).attr('data-gameid'),
                    prediction: $(this).attr('data-prediction')
                },
                dataType: "html",
                success: function (response) {
                    $('#betGrid').html(response);
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            })
        } else {
            $.ajax({
                type: "DELETE",
                url: "/GameBet/Remove",
                data: {
                    __RequestVerificationToken: getToken(),
                    gameId: $(this).attr('data-gameid')
                },
                dataType: "html",
                success: function (response) {
                    $('#betGrid').html(response);
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            })
        }
    })
})

$(function () {
    $.ajax({
        type: "GET",
        url: "/GameBet/GetAll",
        dataType: "html",
        success: function (response) {
            $('#betGrid').html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
})

function showBets() {
    $("#betsTable").removeAttr("hidden");
}
function hideBets() {
    $("#betsTable").attr("hidden", "hidden");
}

function removeMarker(id) {
    document.querySelectorAll(`[data-gameid="${id}"]`).forEach(function (el) {
        el.classList.remove('active');
    });
}

$(function () {
    $.ajax({
        type: "GET",
        url: "/GameBet/GetBetsFromSessionStorageRaw",
        dataType: "html",
        success: function (response) {
            response = JSON.parse(response);
            for (let i = 0; i < response.length; i++) {
                let matchId = response[i].GameId;
                let prediction = response[i].Prediction;
                let elements = document.querySelectorAll(`[data-gameid="${matchId}"]`);
                let className = "";
                switch (prediction) {
                    case '1': className = 'home-bet'; break;
                    case '2': className = 'away-bet'; break;
                    case 'X': className = 'draw-bet'; break;
                }
                elements.forEach(function (el) {
                    if (el.classList.contains(className)) {
                        el.classList.add('active');
                    }
                })
            }
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
})