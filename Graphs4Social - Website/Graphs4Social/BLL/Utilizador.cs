using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BLL
{
    public class Utilizador
    {

        public DataTable getUtilizadoresDisponiveis()
        {
            DAL.UtilizadorGateway lista = new DAL.UtilizadorGateway();
            return lista.getUtilizadoresDisponiveis();
        }

        public string verificaUtilizador(string nome)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.verificaUtilizador(nome);
        }

        public DataTable getPerfil(string nome)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getPerfil(nome);
        }

        public int actualizaPerfil(string username, string nomeCompleto,string dataNasc,string sexo, string avatar)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.actualizaPerfil(username,nomeCompleto,dataNasc,sexo,avatar);
        }

        public int criaPerfil(string username, string nomeCompleto, string dataNasc, string sexo, string avatar)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.criaPerfil(username, nomeCompleto, dataNasc, sexo, avatar);
        }

    }
}
