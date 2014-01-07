<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Graphs4Social.Perfil" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>O Meu Perfil</h2>
    <br />
    <br />
    <strong><asp:Label ID="Label1" runat="server" Text="Nome Completo"></asp:Label></strong>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
    CssClass="field-validation-error" ErrorMessage="O Nome Completo é obrigatório." />
    <br />
    <br />
    <strong><asp:Label ID="Label2" runat="server" Text="Data de Nascimento"></asp:Label></strong>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
    CssClass="field-validation-error" ErrorMessage="A Data de Nascimento é obrigatória." />
    <br />
    <br />
    <strong><asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label></strong>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Masculino</asp:ListItem>
    <asp:ListItem>Feminino</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <strong><asp:Label ID="Label4" runat="server" Text="Avatar"></asp:Label></strong>
    <br />
    <asp:TextBox ID="TextBox4" Text="Url da imagem..." runat="server" onfocus="if(this.value=='Url da imagem...'){this.value=''}else{this.value=this.value}" onblur="if(this.value==''){this.value='Url da imagem...'}else{this.value=this.value}"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
</asp:Content>
