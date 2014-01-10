<%@ Page Title="Amigos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Amigos.aspx.cs" Inherits="Graphs4Social.Amigos" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <asp:Button ID="Button1" runat="server" Text="Adicionar Novos Amigos" OnClick="Button1_Click" />
    <br />
    <br />
    <br />

    <div class="float-left">
    <h2>Lista de Amigos:</h2>
    </div>
    <br />
    <div class="float-right">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="Procurar" />
    </div>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    
</asp:Content>
