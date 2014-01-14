using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class Pedidos : System.Web.UI.Page
    {
        BLL.Utilizador user = new BLL.Utilizador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                string username = User.Identity.Name;
                string existeUser = user.verificaUtilizador(username);
                if (existeUser == "sim")
                {
                    //Pedidos Recebidos
                    DataTable pedidos = user.getPedidosRecebidos(username);
                    GridView1.DataSource = pedidos;
                    GridView1.ShowHeader = false;
                    GridView1.DataBind();

                    //Pedidos Feitos
                    DataTable pedidosfeitos = user.getPedidosFeitos(username);
                    GridView2.DataSource = pedidosfeitos;
                    GridView2.ShowHeader = false;
                    GridView2.DataBind();
                }
                else
                {
                    Response.Redirect("~/Perfil");
                }
            }
            else
            {
                Response.Redirect("~/Account/Login");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string username = User.Identity.Name;

            if (e.CommandName == "Aceitar")
            {
                //Adiciona uma Ligação na Base de dados e Remove o PedidoLigacao

                 int indice = Convert.ToInt32(e.CommandArgument);
                GridViewRow linha = GridView1.Rows[indice];
                
                string nomeDeQuemFezPedido = Convert.ToString(linha.Cells[2].Text); //Converte a linha para string

                Label1.Text = nomeDeQuemFezPedido;

                TextBox1.Visible = true;
                TextBox2.Visible = true;
                Button6.Visible = true;
            }

            if (e.CommandName == "Recusar")
            {
                //Remove o respectivo PedidoLigacao da Base de dados

                int indice = Convert.ToInt32(e.CommandArgument);
                GridViewRow linha = GridView1.Rows[indice];

                string nomeDeQuemFezPedido = Convert.ToString(linha.Cells[2].Text); //Converte a linha para string

                int recusar = user.recusaPedidoAmizade(username, nomeDeQuemFezPedido);
                Response.Redirect("~/Pedidos");
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = User.Identity.Name;
            string nomeAquemPediuAmizade = GridView2.SelectedRow.Cells[1].Text;

            int eliminar = user.eliminaPedidoAmizade(username, nomeAquemPediuAmizade);
            Response.Redirect("~/Pedidos");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string username = User.Identity.Name;
            string nomeDeQuemPediu = Label1.Text;
            int forca = Convert.ToInt32(TextBox1.Text);
            string tagRelacao;
            string aux = TextBox2.Text;
            if (aux != "Qual a Tag de Relação ?")
            {
                tagRelacao = TextBox2.Text;
            }
            else
            {
                tagRelacao = "";
            }

            int aceitar = user.aceitaPedidoAmizade(username, nomeDeQuemPediu, forca, tagRelacao);
            int apaga = user.recusaPedidoAmizade(username, nomeDeQuemPediu);

            Response.Redirect("~/Pedidos");
        }

    }
}