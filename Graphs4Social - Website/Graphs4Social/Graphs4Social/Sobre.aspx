<%@ Page Title="Sobre" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="Graphs4Social.Sobre" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <h2>Sobre</h2>

   <br/>
    <article>
        <p>        
            Trabalho académico desenvolvido no Instituto Superior de Engenharia do Porto, no âmbito da unidade curricular de LAPR V.
        </p>
    </article>

    <aside>
        <h3>Graphs4Social</h3>
        <ul>
        <li><a id="A1" runat="server" href="~/">Geral</a></li>
        <li><a id="A5" runat="server" href="~/MostraPerfil">O Meu Perfil</a></li>
        <li><a id="A2" runat="server" href="~/Amigos">Amigos</a></li>
        <li><a id="A3" runat="server" href="~/Pedidos">Pedidos</a></li>
        <li><a id="A4" runat="server" href="~/Download">Download</a></li>
        </ul>
    </aside>
</asp:Content>