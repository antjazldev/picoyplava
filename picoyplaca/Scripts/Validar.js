var btnValidate = document.getElementById("btnValidate");



btnValidate.onclick = function () {

    var plate = document.getElementById("txtplate").value;//PLACA
    var lastDigitPlate = plate[plate.length - 1];     //ULTIMO DIGITO DE LA PLACA
    var inputdate = document.getElementById("date-input").value;
    var hour = document.getElementById("hour").value;
    var date = new Date($('#date-input').val());
    day = date.getUTCDay();
    var html = "";
    $.ajax({
        url: '/PicoyPlaca/Resultado',
        type: "GET",
        dataType: "json",
        data: { date: inputdate, lastDigit: lastDigitPlate, time: hour, day: day},
        error: function (response) {
            alert("error");
        },
        success: function (response) {
            html = response.html;
            alert(html);
        }
    });
}

var btnLimpiar = document.getElementById("btnLimpiar");
btnLimpiar.onclick = function () {
    document.getElementById("txtplate").value = "";
    document.getElementById("txtdate").value = "";
    document.getElementById("lblRespuesta").innerHTML = "";

}