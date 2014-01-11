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
                Response.Redirect("~/Account/Login");
            }
        }
    }
}