<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Graphs4Social.Login" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Introduza os seus dados para entrar:</h2>
    <br />
    <br />
    <b><asp:Label ID="Label1" runat="server" Text="Nome de Utilizador"></asp:Label></b>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <b><asp:Label ID="Label2" runat="server" Text="Palavra-passe"></asp:Label></b>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entrar" />


</asp:Content>
