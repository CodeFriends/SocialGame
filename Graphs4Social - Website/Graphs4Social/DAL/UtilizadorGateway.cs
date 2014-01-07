using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class UtilizadorGateway : BaseGateway
    {

        public UtilizadorGateway()
		{
			//
			// TODO: Add constructor logic here
			//
		}

        public DataTable getUtilizadoresDisponiveis()
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM Teste");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public string verificaUtilizador(string nome)
        {
            string existe = "nao";
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT username FROM Utilizador WHERE username='"+nome+"'");

                if (ds != null)
                {
                    existe = "sim";
                    return existe;
                }
                else
                {
                 return existe;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

        }

        public DataTable getPerfil(string nome)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT nome_completo,data_nascimento,sexo,avatar FROM Utilizador WHERE username='"+nome+"'");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public int actualizaPerfil(string username, string nomeCompleto, string dataNasc, string sexo, string avatar)
        {
            int sucesso=0;
            try
            {
                sucesso = ExecuteNonQuery(GetConnection(true), "UPDATE Utilizador SET nome_completo='" + nomeCompleto + "', data_nascimento='" + dataNasc + "', sexo='" + sexo + "', avatar='" + avatar + "' WHERE username='" + username + "'");
                return sucesso;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

        }

        public int criaPerfil(string username, string nomeCompleto, string dataNasc, string sexo, string avatar)
        {
            int sucesso = 0;

            BeginTransaction();

            try
            {

                ExecuteNonQuery(CurrentTransaction, "INSERT INTO Utilizador(username,nome_completo,data_nascimento,sexo,avatar,pontos) VALUES ('" + username + "','" + nomeCompleto + "','" + dataNasc + "','" + sexo + "','" + avatar + "','0')");

                CommitTransaction();
                return sucesso;
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                throw new ApplicationException("Erro BD", ex);
            }

        }

    }
}
