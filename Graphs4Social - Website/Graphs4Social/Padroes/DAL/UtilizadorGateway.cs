using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Padroes.DAL
{
    public class UtilizadorGateway : BaseGateway
    {
        public UtilizadorGateway()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataTable getUtilizadores()
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT username FROM Utilizador");
                return ds.Tables[0];
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }
        /*
        public DataSet registaUtilizador(string user, string pass, string nome, string data, int sexo, string caminhoImagem)
        {
            try
            {
                OleDbCommand sqlcmd = new OleDbCommand("SELECT MAX(id_utilizador) FROM Utilizador");

                DataSet ds = ExecuteQuery(GetConnection(false), "INSERT INTO Utilizador VALUES (" + user + "," + pass + "," + nome + "," + data + "," + sexo + "," + caminhoImagem + ")");
                return;
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }*/
    }
}
