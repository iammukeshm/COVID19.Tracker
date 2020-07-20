$("#stateSelect2").select2({
    placeholder: "Select a State",
    theme: "bootstrap4",
    ajax: {
        url: "/api/state/search",
        contentType: "application/json; charset=utf-8",
        data: function (params) {
            var queryParameters =
            {
                term: params.term,
            };
            return queryParameters;
        },
        processResults: function (result) {
            return {
                results: $.map(result, function (item) {
                    return {
                        id: item.code,
                        text: item.name,
                        code: item.code
                    };
                }),
            };
        }
    },
    escapeMarkup: function (m) {
        return m;
    }
}).on('change', async function () {
    data = $("#stateSelect2").select2("data")[0];
    await loadData(data);

    $("#districtsTable").show();
});



$(document).ready(async function () {
    animateNumbers();
    $("#countryButton").click(async function () {
        $("#districtsTable").hide();
        var data = { id: "TT", text : "India" }
        await loadData(data);
    }); 
});

function animateNumbers() {
    $('.Count').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
            duration: 1000,
            easing: 'swing',
            step: function (now) {
                $(this).text(Math.ceil(now).toLocaleString('en'));
            }
        });
    });
}

async function loadData(data) {
    var url = "/api/stats?code=" + data.id;
    let response = await fetch(url);

    if (response.ok) {
        let json = await response.json();
        console.log(json);
        $('#countryStateLabel').text(data.text);
        var date = new Date($('#selectedDate').val());
        var formattedDate = moment(date).format("YYYY-MM-DD");
        $('#confirmedDelta').text(json.delta.confirmed);
        $('#confirmedTotal').text(parseInt(json.total.confirmed));
        $('#testedUpdatedDate').text("As of " + moment(json.meta.last_updated).format("DD MMMM, YYYY"));
        $('#testedTotal').text(json.total.tested);
        $('#recoveredDelta').text(parseInt(json.delta.recovered));
        $('#recoveredTotal').text(json.total.recovered);
        $('#deceasedDelta').text(parseInt(json.delta.deceased));
        $('#deceasedTotal').text(json.total.deceased);
        animateNumbers();
    } else {
        alert("HTTP-Error: " + response.status);

    }
}