<%@ Page Title="Geral" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Geral.aspx.cs" Inherits="Graphs4Social.Geral" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Informações Gerais</h2>
    <br />
    <br />

    <asp:Panel ID="Panel1" runat="server" >
    <div style="width:33.33%;position:relative;float:left;">
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
    </div>

    <div style="width:33.34%;position:relative;float:left;">
    <h5>As Minhas Tags Pessoais:</h5>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Link" SelectText="Remover" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="Button5" runat="server" Text="Adicionar Tag Nova" OnClick="Button5_Click" />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Visible="false" Text="Qual a nova Tag ?" onfocus="if(this.value=='Qual a nova Tag ?'){this.value=''}else{this.value=this.value}" onblur="if(this.value==''){this.value='Qual a nova Tag ?'}else{this.value=this.value}"></asp:TextBox>
    <asp:Button ID="Button6" runat="server" Text="Guardar" Visible="false" OnClick="Button6_Click"/>
    <br />
    <h5>As Minhas Tags de Relação:</h5>
    <br />
    <asp:GridView ID="GridView5" runat="server">
    </asp:GridView>
    </div>

    <div style="width:33.33%;position:relative;float:left;">
    <h5>A minha Pontuação: </h5>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <h5>Número total de amigos: </h5>
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <h5>O Meu Ranking segundo a Dimensão da Rede:</h5>
    <br />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br />
    <h5>O Meu Ranking segundo a Fortaleza da Rede:</h5>
    <br />
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </div>
    </asp:Panel>

    <div style="width:100%">
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    </div>
    <div style="width:100%">
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    </div>

    <asp:Panel ID="Panel2" runat="server"  >
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Top10 segundo a Pontuação:</h5>
    <br />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    <br />
    </div>
     
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Top10 segundo a Dimensão da Rede:</h5>
    <br />
    <asp:GridView ID="GridView3" runat="server">
    </asp:GridView>
    <br />
    </div>
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Top10 segundo a Fortaleza da Rede:</h5>
    <br />
    <asp:GridView ID="GridView4" runat="server">
    </asp:GridView>
    <br />
    </div>
    </asp:Panel>

    <div style="width:100%">
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    </div>
    <div style="width:100%">
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    <p><br /><br /><br /></p>
    </div>

    <asp:Panel ID="Panel3" runat="server"  >
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Utilizadores existentes:</h5>
    <br />
    <asp:GridView ID="GridView6" runat="server">
    </asp:GridView>
    <br />
    </div>
     
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Tag Cloud de Utilizadores:</h5>
    <br />
    <asp:GridView ID="GridView7" runat="server">
    </asp:GridView>
    <br />
    </div>
    <div style="width:33.33%;position:relative;float:left;">
    <h5>Tag Cloud de Relações:</h5>
    <br />
    <asp:GridView ID="GridView8" runat="server">
    </asp:GridView>
    <br />
    </div>
    </asp:Panel>
    <br />
</asp:Content>
