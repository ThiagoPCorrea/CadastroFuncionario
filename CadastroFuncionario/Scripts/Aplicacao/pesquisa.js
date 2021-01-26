$(document).ready(function () {
    maskCPF();
});

function limpar() {
    $("#cpf").val("");
    $("#tabelaFuncionarios").html('');
}

function pesquisar() {
    cleanModal()
    var semaforo = true;

    semaforo = validaCamposObrigatorios();

    if (!validaCPF()) {
        errorField($("#cpf"))
        showModal("CPF Inválido")
        semaforo = false;
    }

    if (semaforo)
        $("#btnSearch").click()

}