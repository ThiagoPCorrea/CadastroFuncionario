<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadastroFuncionario._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="center">
            <h1 class="red">Empresa XPTO</h1>
            <h3 class="red">Página Inicial</h3>
        </div>
    </div>

    <div class="row" style="margin-top: 10%">
        <div class="center">
            <a runat="server" href="~/Cadastrar" class="btn btn-success" style="margin-right:10%"><i class="arrow-white left"></i>Cadastro</a>

            <a runat="server" href="~/Pesquisar" class="btn btn-default bg-gray" style="margin-left:10%">Pesquisa <i class="arrow-black right"></i></a>

        </div>
    </div>

</asp:Content>
