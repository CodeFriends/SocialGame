using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class AdicionaAmigo : System.Web.UI.Page
    {
        BLL.Utilizador user = new BLL.Utilizador();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (User.Identity.IsAuthenticated)
            {
                string nome = User.Identity.Name;
                string existeUser = user.verificaUtilizador(nome);
                if (existeUser == "sim")
                {
                    DataTable table = user.getUtilizadoresDisponiveis(nome);
                    GridViewUsers.DataSource = table;
                    GridViewUsers.ShowHeader = false;
                    GridViewUsers.DataBind();
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

        protected void GridViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = User.Identity.Name;
            string nome = GridViewUsers.SelectedRow.Cells[1].Text;

            int criaPedido = user.criaPedido(username, nome);

            Response.Redirect("~/AdicionaAmigo");
        }
    }
}