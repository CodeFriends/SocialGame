<%@ Page Title="Registar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registar.aspx.cs" Inherits="Graphs4Social.Registar" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Preencha os seguintes dados para Registar nova conta:</h2>
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
    <b><asp:Label ID="Label3" runat="server" Text="Nome Completo"></asp:Label></b>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <b><asp:Label ID="Label4" runat="server" Text="Data de Nascimento"></asp:Label></b>
    <br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <br />
    <b><asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label></b>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="0">Feminino</asp:ListItem>
        <asp:ListItem Value="1">Masculino</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />

    <br />
    <b><asp:Label ID="Label6" runat="server" Text="Avatar"></asp:Label></b>

    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Registar" OnClick="Button1_Click" />
    <br />

</asp:Content>
