using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Graphs4Social
{
    public partial class Geral : System.Web.UI.Page
    {
        BLL.Utilizador user = new BLL.Utilizador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    string username = User.Identity.Name;

                    //Estado Humor
                    string existe = user.verificaEstadoHumor(username);
                    if (existe == "sim")
                    {
                        DataTable estado = user.getIDEstadoHumor(username);
                        string id = Convert.ToString(estado.Rows[0]["id_estado_humor"]);
                        int idEstado = Convert.ToInt32(id);
                        DataTable imagemEstado = user.getImagemEstado(idEstado);
                        Image1.ImageUrl = Convert.ToString(imagemEstado.Rows[0]["imagem"]);
                    }
                    else
                    {
                        Image1.ImageUrl="http://www.clker.com/cliparts/9/1/4/0/11954322131712176739question_mark_naught101_02.svg.med.png";
                    }

                    //Pontos
                    DataTable pontos = user.getPontos(username);
                    Label1.Text = Convert.ToString(pontos.Rows[0]["pontos"]) + " pontos.";

                    //Total de amigos
                    DataTable total = user.getAmigos(username);
                    Label2.Text = Convert.ToString(total.Rows.Count) + " amigos no total.";

                    //Ranking
                    //A completar ...

                }
                else
                {
                Response.Redirect("~/Account/Login");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Mostrar e Preencher a dropdownlist
            DropDownList1.Visible = true;
            
            DataTable dtUsers = user.getEstados();
            DropDownList1.DataSource = dtUsers;
            DropDownList1.DataTextField = "descricao";
            DropDownList1.DataBind();

            Button1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = User.Identity.Name;
            string estadoH = DropDownList1.SelectedValue;

            //Pesquisa o id do estado escolhido
            DataTable estadoEscolhido = user.selecionaIdEstado(estadoH);
            int idEstadoHumor = Convert.ToInt32(estadoEscolhido.Rows[0]["id_estado_humor"]);
            
            //Faz Update à base dados, à tabela utilizador com o id do estado de humor escolhido
            user.actualizaEstado(username,idEstadoHumor);

            Response.Redirect("~/Geral");
        }


    }
}