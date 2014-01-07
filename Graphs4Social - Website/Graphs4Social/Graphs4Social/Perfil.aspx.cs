using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class Perfil : System.Web.UI.Page
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

                    TextBox1.Text = Convert.ToString(dtUsers.Rows[0]["nome_completo"]);
                    TextBox2.Text = Convert.ToString(dtUsers.Rows[0]["data_nascimento"]);
                    string sexo = Convert.ToString(dtUsers.Rows[0]["sexo"]);
                    if (sexo == "Masculino")
                    {
                        DropDownList1.SelectedValue = "Masculino";
                    }
                    else
                    {
                        DropDownList1.SelectedValue = "Feminino";
                    }
                    TextBox4.Text = Convert.ToString(dtUsers.Rows[0]["avatar"]);
                }
                else
                {
                    //Se não existe perfil do utilizador, então fica tudo em branco (por preencher)
                }
            }
            else
            {
                Response.Redirect("~/Account/Login");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = User.Identity.Name;
            string nomeCompleto = TextBox1.Text;
            string dataNasc = TextBox2.Text;
            string sexo = DropDownList1.SelectedValue;
            string avatar = TextBox4.Text;

            //Insere os dados na BD (se ja existir alguem com esse username, faz apenas UPDATE aos dados, senao, como ainda nao existe, faz INSERT)
            string existe = perfil.verificaUtilizador(username);

            if (existe == "sim")
            {
                //Faz update
                perfil.actualizaPerfil(username,nomeCompleto,dataNasc,sexo,avatar);
            }
            else
            {
                //Faz insert
                perfil.criaPerfil(username,nomeCompleto,dataNasc,sexo,avatar);
            }
            Response.Redirect("~/MostraPerfil");
        }
    }
}