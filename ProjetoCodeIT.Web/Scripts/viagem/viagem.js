var _urlViagem;

function initScript(urlViagem) {
    _urlViagem = urlViagem;
};

$(document).on('click', '.btn-gerar-viagem', function () {

    $.ajax({
        url: _urlViagem,
        type: 'POST',
        contentType: 'application/json',
        data: { },
        success: function (data) {       
            $('form').html(data);
        },
        error: function (request, status, erro) {         
            swal("Oops...!", "Deu Ruimmm", "error");
            return false;
        }
    });   

});
