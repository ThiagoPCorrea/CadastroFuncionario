$(document).ready(function () {
    maskCPF();
    maskTel();
    maskRG();
    maskCEP();
    fixNumberInput();
    limiteUpload(50);
});

function maskTel() {
    var SPMaskBehavior = function (val) {
        return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00000';
    },
        spOptions = {
            onKeyPress: function (val, e, field, options) {
                field.mask(SPMaskBehavior.apply({}, arguments), options);
            }
        };

    $('#tel').mask(SPMaskBehavior, spOptions);
}

function maskRG() {
    $('#rg').mask('00.000.000-0');
}

function maskCEP() {
    $('#cep').mask('00000-000');
}

function fixNumberInput() {
    var userName = document.querySelector('#numero');

    userName.addEventListener('input', restrictNumber);
    function restrictNumber(e) {
        var newValue = this.value.replace(new RegExp(/[^\d]/, 'ig'), "");
        this.value = newValue;
    }
}

function limpa_cep() {
    $("#rua").val("");
    $("#bairro").val("");
    $("#cidade").val("");
    $("#estado").val("");
}

function checarCEP() {
    var cep = $("#cep").val().replace(/\D/g, '');
    if (cep) {
        var validacep = /^[0-9]{8}$/;
        if (validacep.test(cep)) {

            $("#rua").val("...");
            $("#bairro").val("...");
            $("#cidade").val("...");
            $("#estado").val("...");

            $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                if (!("erro" in dados)) {
                    $("#rua").val(dados.logradouro);
                    $("#rua").change()
                    $("#bairro").val(dados.bairro);
                    $("#bairro").change()
                    $("#cidade").val(dados.localidade);
                    $("#cidade").change()
                    $("#estado").val(dados.uf);
                    $("#estado").change()
                }
                else {
                    errorCEP()
                }
            });
        }
        else {
            errorCEP()
        }
    } else {
        errorCEP()
    }
}

function anexar() {
    $("#upload").click();
}

function limiteUpload(valorMB) {
    var uploadField = document.getElementById("upload");

    uploadField.onchange = function () {
        if (this.files[0].size > 1048576 * valorMB) {
            alert("File is too big!");
            this.value = "";
            $("#lblDocumento").text("")
        } else {
            $("#lblDocumento").text(this.files[0].name)
        }
    };
}


function limpar() {
    $("#nome").val("");
    $("#dataNascimento").val("");
    $('#sexo').prop('selectedIndex', 0);
    $("#cpf").val("");
    $("#tel").val("");
    $("#rg").val("");
    $("#orgaoEmissor").val("");
    $("#cep").val("");
    $("#rua").val("");
    $("#numero").val("");
    $("#bairro").val("");
    $("#cidade").val("");
    $("#estado").val("");
    $("#complemento").val("");
    $("#cargo").val("");
    $("#dataAdmissao").val("");
    $("#ctps").val("");
    $("#upload").val("");
    $("#lblDocumento").text("")
}

function salvar() {
    cleanModal()
    var semaforo = true;

    semaforo = validaCamposObrigatorios();

    if (!validaCPF()) {
        errorField($("#cpf"))
        showModal("CPF Inválido")
        semaforo = false;
    }

    if (semaforo)
        $("#btnSalvar").click()
}


function errorCEP() {
    $("#rua").val("");
    $("#bairro").val("");
    $("#cidade").val("");
    $("#estado").val("");
    errorField($("#cep"))
    showModal("CEP Inválido")
}

