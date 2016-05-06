$(document).ready(function () {
    $("button").click(function () {
        var nombre = $("#nombre").val();
        var telefono = $("#phone").val();
        var postdata = {};
        postdata["Nombre"] = nombre;
        postdata["Phone"] = telefono;

        var url = "http://localhost:1367/TicketService.svc/AddTicket";
        $.ajax({
            type: "POST",
            url: url,

            contentType: "application/json; charset=utf-8",
            //contentType: "application/json",
            data: JSON.stringify(postdata),
            dataType: "json",
            success: function (data) { location.href = "http://localhost:1367/TicketService.svc/Ticket" },

            error: function (a, b, c) { console.log(a); alert("error"); }
        });

    });
});