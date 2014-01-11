<%@ Page Title="Pedidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Graphs4Social.Pedidos" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Pedidos de amizade recebidos:</h2>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Aceitar" Text="Aceitar" />
            <asp:ButtonField ButtonType="Button" CommandName="Recusar" Text="Recusar" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <h2>Pedidos de amizade efectuados:</h2>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
