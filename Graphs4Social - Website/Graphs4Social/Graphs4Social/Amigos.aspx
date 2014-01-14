<%@ Page Title="Amigos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Amigos.aspx.cs" Inherits="Graphs4Social.Amigos" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Adicionar Novos Amigos" OnClick="Button1_Click" Height="50px" />
    <br />
    <br />
    <br />

    <div style="width:100%">
    <h2>Lista de Amigos:</h2>
    <br /><br />
    </div>

    <asp:Panel ID="Panel1" runat="server" >
    <div style="width:50%;position:relative;float:left;">
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Perfil" Text="Ver Perfil" />
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <br />
    </div>
    <div style="width:50%;position:relative;float:left;">
    <br />
    <strong><asp:Label ID="Label1" runat="server" Text="Nome Completo" Visible="false" ></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="" Visible="false"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label2" runat="server" Text="Data de Nascimento" Visible="false"></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="" Visible="false"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label3" runat="server" Text="Sexo" Visible="false"></asp:Label></strong>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="" Visible="false"></asp:Label>
    <br />
    <br />
    <strong><asp:Label ID="Label4" runat="server" Text="Avatar" Visible="false"></asp:Label></strong>
    <br />
    <br />
    <asp:Image ID="Image1" width="125" height="125" runat="server" Visible="false"/>
    <br />
    </div>
    </asp:Panel>


</asp:Content>
