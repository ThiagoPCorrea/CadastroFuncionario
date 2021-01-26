<%@ Page Title="Pesquisar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisar.aspx.cs" Inherits="CadastroFuncionario.Pesquisar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="center">
            <h2 class="red">Pesquisa de Funcionários</h2>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="center">
            <label for="cpf" class="padding-right-1">CPF:</label>
            <input class="cpf margin-right-5 obrigatorio" type="text" runat="server" id="cpf" placeholder="000.000.000-00">
        </div>

        <br />

        <div class="center">
            <button class="btn btn-success margin-right-5" onclick="pesquisar()" type="button">Pesquisar</button>
            <asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Style="display: none" />
            <button class="btn btn-primary margin-right-5" onclick="limpar()" type="button">Limpar</button>
            <a runat="server" href="~/" class="btn btn-danger">Voltar</a>
        </div>

        <br />

        <div class="center">
            <table id="tabelaFuncionarios" class="table table-primary" runat="server">

            </table>
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
                        <button type="button" class="btn btn-danger" data-dismiss="modal">OK</button>
                    </div>
                </div>

            </div>
        </div>
        <%: Scripts.Render("~/bundles/pesquisa") %>
    </div>
</asp:Content>
