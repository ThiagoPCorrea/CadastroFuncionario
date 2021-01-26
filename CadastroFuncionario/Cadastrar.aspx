<%@ Page Title="Cadastrar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="CadastroFuncionario.Cadastrar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="center">
            <h2 class="red">Cadastro de Funcionários</h2>
        </div>
    </div>
    <div class="row">
        <div>
            <h4 class="green">Dados Pessoais</h4>
            <div>
                <label for="nome" class="padding-right-1">Nome:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="nome" runat="server" />

                <label for="dataNascimento" class="padding-right-1">Data de Nascimento:</label>
                <input class="margin-right-5 obrigatorio" type="date" id="dataNascimento" runat="server" />

                <label for="sexo" class="padding-right-1">Sexo:</label>
                <select id="sexo" class="obrigatorio" runat="server">
                    <option value="">Selecione</option>
                    <option value="M">Masculino</option>
                    <option value="F">Feminino</option>
                    <option value="I">Indefinido</option>
                </select>
            </div>
            <br />
            <div>
                <label for="cpf" class="padding-right-1">CPF:</label>
                <input class="cpf margin-right-5 obrigatorio" type="text" id="cpf" placeholder="000.000.000-00" runat="server">


                <label for="tel" class="padding-right-1">Tel:</label>
                <input class="tel margin-right-5 obrigatorio" type="text" id="tel" placeholder="(00) 00000-0000" runat="server">
            </div>
            <br />
            <div>
                <label for="rg" class="padding-right-1">RG:</label>
                <input class="rg margin-right-5 obrigatorio" type="text" id="rg" placeholder="00.000.000-0" runat="server">

                <label for="orgaoEmissor" class="padding-right-1">Órgão Emissor:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="orgaoEmissor" runat="server" />
            </div>
        </div>

        <br />
        <br />

        <div>
            <h4 class="green">Endereço</h4>
            <div>
                <label for="cep" class="padding-right-1">CEP:</label>
                <input class="obrigatorio" type="text" id="cep" placeholder="00000-000" runat="server" />
                <button class="margin-right-5" onclick="checarCEP()" type="button"><i class="fa fa-search"></i></button>

                <label for="rua" class="padding-right-1">Rua:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="rua" runat="server" />

                <label for="numero" class="padding-right-1">Nº:</label>
                <input class="margin-right-5" type="text" id="numero" runat="server" />
            </div>
            <br />

            <div>
                <label for="bairro" class="padding-right-1">Bairro:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="bairro" runat="server" />

                <label for="cidade" class="padding-right-1">Cidade:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="cidade" runat="server" />

                <label for="estado" class="padding-right-1">Estado:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="estado" runat="server" />
            </div>
            <br />
            <div>
                <label for="complemento" class="padding-right-1">Complemento:</label>
                <input class="margin-right-5" type="text" id="complemento" runat="server" />
            </div>
        </div>

        <br />
        <br />

        <div>
            <h4 class="green">Função</h4>
            <div>
                <label for="cargo" class="padding-right-1">Cargo:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="cargo" runat="server" />

                <label for="dataAdmissao" class="padding-right-1">Data de Admissão:</label>
                <input class="margin-right-5 obrigatorio" type="date" id="dataAdmissao" runat="server" />
            </div>

            <br />

            <div>
                <label for="ctps" class="padding-right-1">CTPS:</label>
                <input class="margin-right-5 obrigatorio" type="text" id="ctps" runat="server" />


                <label for="upload" class="padding-right-1">Envio de Documento:</label>
                <button class="btn btn-warning" onclick="anexar()" type="button">Anexar</button>
                <label id="lblDocumento"></label>
                <input class="margin-right-5 obrigatorio" type="file" id="upload" style="display: none" runat="server" />
            </div>

            <br />
            <br />
            <div class="center">
                <button class="btn btn-success margin-right-5" onclick="salvar()" type="button">Salvar</button>
                <asp:Button ID="btnSalvar" OnClick="btnSalvar_Click" runat="server" Style="display: none" />
                <button class="btn btn-primary margin-right-5" onclick="limpar()" type="button">Limpar</button>
                <a runat="server" href="~/" class="btn btn-danger">Voltar</a>
            </div>

        </div>

        <div id="modalError" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Erro</h4>
                    </div>
                    <div class="modal-body">
                        <p id="textoModal"></p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" onclick="cleanModal()" data-dismiss="modal">OK</button>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <%: Scripts.Render("~/bundles/cadastro") %>
</asp:Content>
