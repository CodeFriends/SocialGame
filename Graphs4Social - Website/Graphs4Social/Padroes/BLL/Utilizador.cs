using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Padroes.BLL
{
    public class Utilizador
    {


        public Utilizador()
        {
        }

        public DataTable getUtilizadores()
        {
            DAL.UtilizadorGateway dal = new Padroes.DAL.UtilizadorGateway();
            return dal.getUtilizadores();
        }

        /*
        public DataSet registaUtilizador(string user, string pass, string nome, string data, int sexo, string caminhoImagem)
        {
            DAL.UtilizadorGateway dal = new Padroes.DAL.UtilizadorGateway();
            return dal.registaUtilizador(user, pass, nome, data, sexo, caminhoImagem);
        }
        */
    }
}
