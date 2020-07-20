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
            console.log(result);
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
}).on('change', function () {
    $(this).valid();
});