function maskCPF() {
    $('#cpf').mask('000.000.000-00', { reverse: true });
}

function validaCPF() {
    var cpf = $("#cpf").val().replace(/\D/g, '');
    var digito2 = parseInt(cpf.slice(cpf.length - 1));
    var digito1 = parseInt(cpf.slice(cpf.length - 2, cpf.length - 1));
    var corpo = cpf
        .slice(0, cpf.length - 2)
        .split("")
        .map((n) => parseInt(n));

    var i = 10;
    var reducer = (accumulador, valor) => {
        accumulador += valor * i;
        i--;
        return accumulador;
    };
    var verificadorDig1 = (corpo.reduce(reducer, 0) * 10) % 11;
    i = 11;
    corpo.push(digito1);
    var verificadorDig2 = (corpo.reduce(reducer, 0) * 10) % 11;

    if (verificadorDig2 === 10) verificadorDig2 = 0;

    return verificadorDig1 === digito1 && verificadorDig2 === digito2;
}

function validaCamposObrigatorios() {

    var camposObrigatorios = $(".obrigatorio")
    var camposFalhos = []

    $.map(camposObrigatorios, function (campos) {
        if (!campos.value) {
            camposFalhos.push(campos)
        }
    })

    if (camposFalhos.length > 0) {
        $.map(camposFalhos, function (campos) {
            if (campos.name == "upload") {
                $("#lblDocumento").text("Campo Obrigatorio")
                $("#lblDocumento").css("color", "red");

                $(campos).change(function () {
                    $("#lblDocumento").css("color", "black");
                    $("#lblDocumento").text("")
                })
            } else {
                errorField(campos)
            }
        })
        showModal("Preencha os campos obrigatórios.");
        return false;
    }
    return true;
}

function errorField(field) {
    $(field).addClass("error-input")
    $(field).change(function () {
        $(field).removeClass("error-input")
    })
}

function showModal(message) {
    $("#textoModal").text($("#textoModal").text() + "  " + message)
    $('#modalError').modal('show');
}


function cleanModal() {
    $("#textoModal").text("")
}

function pesquisar() {

}