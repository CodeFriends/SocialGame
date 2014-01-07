<%@ Page Title="Adicionar Amigo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionaAmigo.aspx.cs" Inherits="Graphs4Social.AdicionaAmigo" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de Utilizadores disponíveis:</h2>
    <br />
    <asp:GridView ID="GridViewUsers" runat="server">
    </asp:GridView>
    <br />
    <asp:ListView ID="ListView1" runat="server">
    </asp:ListView>
    <br />

</asp:Content>
