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
                DataTable table = user.getUtilizadoresDisponiveis(nome);
                GridViewUsers.DataSource = table;
                GridViewUsers.ShowHeader = false;
                GridViewUsers.DataBind();

            }
            else
            {
                Response.Redirect("~/Account/Login");
            }
        }

        protected void GridViewUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Pedido")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow linha = GridViewUsers.Rows[index];
                
                string last = linha.Cells.ToString();
                string nome = Convert.ToString(linha.Cells.ToString());
                string nm = linha.ToString();

                Label1.Text = nome;

                //Response.Redirect("~/AdicionaAmigo");
            }
        }
    }
}