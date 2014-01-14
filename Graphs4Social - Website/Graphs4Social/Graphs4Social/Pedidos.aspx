<%@ Page Title="Pedidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Graphs4Social.Pedidos" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Pedidos de amizade recebidos:</h2>
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" >
    <div style="width:50%;position:relative;float:left;">
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Aceitar" Text="Aceitar" />
            <asp:ButtonField ButtonType="Button" CommandName="Recusar" Text="Recusar" />
        </Columns>
    </asp:GridView>
    </div>
    <div style="width:50%;position:relative;float:left;">
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Visible="false" Text="Qual a Força da Ligação ?" onfocus="if(this.value=='Qual a Força da Ligação ?'){this.value=''}else{this.value=this.value}" onblur="if(this.value==''){this.value='Qual a Força da Ligação ?'}else{this.value=this.value}"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
    CssClass="field-validation-error" ErrorMessage="A Força de Ligação é Obrigatória." />
        <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="DataTypeCheck" Type="Integer" 
 ControlToValidate="TextBox1" CssClass="field-validation-error" ErrorMessage="A Força de Ligação tem de ser um número inteiro." />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Visible="false" Text="Qual a Tag de Relação ?" onfocus="if(this.value=='Qual a Tag de Relação ?'){this.value=''}else{this.value=this.value}" onblur="if(this.value==''){this.value='Qual a Tag de Relação ?'}else{this.value=this.value}"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Guardar" Visible="false" OnClick="Button6_Click"/>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
        <br />
        <br />
    </div>
    </asp:Panel>

    <div style="width:100%;">
    <p><br /><br /><br /></p>
    </div>

    <div style="text-align:left">
    <h2>Pedidos de amizade efectuados:</h2>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" >
        <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Eliminar" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    </div>
</asp:Content>
