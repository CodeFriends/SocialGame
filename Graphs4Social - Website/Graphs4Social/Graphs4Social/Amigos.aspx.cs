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
                DataTable amigos = user.getAmigos(username);
                GridView1.DataSource = amigos;
                GridView1.ShowHeader = false;
                GridView1.DataBind();
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
    }
}