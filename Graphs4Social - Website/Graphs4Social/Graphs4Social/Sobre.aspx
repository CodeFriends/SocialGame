<%@ Page Title="Sobre" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="Graphs4Social.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <h2>Sobre</h2>

   <br/>
    <article>
        <p>        
            Trabalho desenvolvido no âmbito da unidade curricular de LAPR V.
        </p>
    </article>

    <aside>
        <h3>Graphs4Social</h3>
        <ul>
        <li><a runat="server" href="~/">Geral</a></li>
        <li><a runat="server" href="~/Amigos">Amigos</a></li>
        <li><a runat="server" href="~/Pedidos">Pedidos</a></li>
        <li><a runat="server" href="~/Download">Download</a></li>
        </ul>
    </aside>
</asp:Content>