<%@ Page Title="Adicionar Amigo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionaAmigo.aspx.cs" Inherits="Graphs4Social.AdicionaAmigo" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de Utilizadores disponíveis:</h2>
    <br />
    <asp:GridView ID="GridViewUsers" runat="server" OnRowCommand="GridViewUsers_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Enviar Pedido Amizade" CommandName="Pedido" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />

</asp:Content>
