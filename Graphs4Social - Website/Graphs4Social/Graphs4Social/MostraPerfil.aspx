<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostraPerfil.aspx.cs" Inherits="Graphs4Social.MostraPerfil" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>O Meu Perfil</h2>
    <br />
    <br />
    <strong><asp:Label ID="Label1" runat="server" Text="Nome Completo"></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label2" runat="server" Text="Data de Nascimento"></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label4" runat="server" Text="Avatar"></asp:Label></strong>
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Alterar" OnClick="Button1_Click" />
    
</asp:Content>
