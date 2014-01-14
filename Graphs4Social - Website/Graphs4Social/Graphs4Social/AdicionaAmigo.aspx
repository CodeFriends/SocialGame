<%@ Page Title="Adicionar Amigo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionaAmigo.aspx.cs" Inherits="Graphs4Social.AdicionaAmigo" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de Utilizadores disponíveis:</h2>
    <br />
    <br />
    <asp:GridView ID="GridViewUsers" runat="server" OnSelectedIndexChanged="GridViewUsers_SelectedIndexChanged" >
        <Columns> <asp:CommandField ButtonType="Button" SelectText="Enviar Pedido de Amizade" ShowSelectButton="True" /> </Columns>
    </asp:GridView>
    <br />

</asp:Content>
