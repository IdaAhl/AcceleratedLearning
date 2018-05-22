$("#demoButton").click(function () {


    var n = $("#Tal").val();

        $.ajax({
            url: "/API5/square/",
            data: {number: n}

    })
        .done(function (result) {

            alert(result);

        })
        .fail(function (xhr, status, error) {

                alert(error);
        });
});