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
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (User.Identity.IsAuthenticated)
            {
                Utilizador user = (Utilizador)Session["User"];

                int id_utiliz = user.id;
                //string nome = User.Identity.ToString();
                //string nm = User.Identity.Name;
                DataTable dtusers = user.getUtilizadores(id_utiliz);
                GridViewUsers.DataSource = dtusers;
                GridViewUsers.DataBind();
            }
            else
            {
                Response.Redirect("~/Login");
            }*/

            BLL.Utilizador user = new BLL.Utilizador();
            DataTable dtclientes = user.getUtilizadoresDisponiveis();
            GridViewUsers.DataSource = dtclientes;
            GridViewUsers.DataBind();

        }
    }
}