using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class MostraPerfil : System.Web.UI.Page
    {
        BLL.Utilizador perfil = new BLL.Utilizador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                string username = User.Identity.Name;
                string existe = perfil.verificaUtilizador(username);

                if (existe == "sim")
                {
                    DataTable dtUsers = perfil.getPerfil(username);

                    Label5.Text= Convert.ToString(dtUsers.Rows[0]["nome_completo"]);
                    Label6.Text= Convert.ToString(dtUsers.Rows[0]["data_nascimento"]);
                    Label7.Text = Convert.ToString(dtUsers.Rows[0]["sexo"]);
                    Image1.ImageUrl = Convert.ToString(dtUsers.Rows[0]["avatar"]);
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
            Response.Redirect("~/Perfil");
        }
    }
}