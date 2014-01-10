<%@ Page Title="Geral" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Geral.aspx.cs" Inherits="Graphs4Social.Geral" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Informações Gerais</h2>
    <br />
    <br />
    <h5>Estado de Humor actual:</h5>
    <br />
    <asp:Image ID="Image1" width="125" height="125" runat="server" />
    <br />
    <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Alterar" OnClick="Button2_Click" />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Visible="false"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Guardar" Visible="false" OnClick="Button1_Click"/>
    <br />
    <h5>A minha Pontuação: </h5>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <h5>Número total de amigos: </h5>
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <h4>Ranking Top10 de Pontuações: </h4>
    <br />
    <br />

</asp:Content>
