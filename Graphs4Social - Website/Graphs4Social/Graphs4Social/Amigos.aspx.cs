using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class Amigos : System.Web.UI.Page
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
                    DataTable amigos = user.getAmigos(username);
                    GridView1.DataSource = amigos;
                    GridView1.ShowHeader = false;
                    GridView1.DataBind();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdicionaAmigo");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Perfil")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow linha = GridView1.Rows[index];
                string nm = Convert.ToString(linha.Cells[2].Text);

                DataTable verPerfil = user.verPerfil(nm);

                Label5.Text = Convert.ToString(verPerfil.Rows[0]["nome_completo"]);
                Label6.Text = Convert.ToString(verPerfil.Rows[0]["data_nascimento"]);
                Label7.Text = Convert.ToString(verPerfil.Rows[0]["sexo"]);
                Image1.ImageUrl = Convert.ToString(verPerfil.Rows[0]["avatar"]);

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Image1.Visible = true;
            }

            if (e.CommandName == "Eliminar")
            {
                string username = User.Identity.Name;

                //2 maneiras de saber o indice da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                //Aceder ao conteudo da linha da Gridview
                GridViewRow linha = GridView1.Rows[index];
                string nome = Convert.ToString(linha.Cells[2].Text);

                int elimina = user.eliminaAmigo(username,nome);

                Response.Redirect("~/Amigos");
            }
        }

    }
}