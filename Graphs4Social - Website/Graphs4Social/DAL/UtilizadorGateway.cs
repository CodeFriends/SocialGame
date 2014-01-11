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

        public DataTable getUtilizadoresDisponiveis(string nome)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "  SELECT nome_completo FROM Utilizador WHERE username!='"+nome+"' AND nome_completo NOT IN (SELECT nome_completo FROM Utilizador WHERE id_utilizador IN (SELECT id_utilizador2 FROM Ligacao WHERE id_utilizador1 IN (SELECT id_utilizador FROM Utilizador WHERE username='"+nome+"'))) AND nome_completo NOT IN (SELECT nome_completo FROM Utilizador WHERE id_utilizador IN (SELECT id_utilizador2 FROM PedidoLigacao WHERE id_utilizador1 IN (SELECT id_utilizador FROM Utilizador WHERE username='"+nome+"')))");
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

                if (ds.Tables[0].Rows.Count != 0)
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

        public DataTable getEstados()
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT descricao FROM EstadoHumor");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getIDEstadoHumor(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT id_estado_humor FROM Utilizador WHERE username='"+username+"'");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getImagemEstado(int idEstado)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT imagem FROM EstadoHumor WHERE id_estado_humor='" + idEstado + "'");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public string verificaEstadoHumor(string username)
        {
            string existe = "nao";
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT id_estado_humor FROM Utilizador WHERE username='" + username + "'");

                if (!ds.Tables[0].Rows[0].IsNull("id_estado_humor"))
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

        public DataTable selecionaIdEstado(string estadoH)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT id_estado_humor FROM EstadoHumor WHERE descricao='" + estadoH + "'");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public int actualizaEstado(string username, int idEstadoHumor)
        {
            int sucesso = 0;
            try
            {
                sucesso = ExecuteNonQuery(GetConnection(true), "UPDATE Utilizador SET id_estado_humor='" + idEstadoHumor + "' WHERE username='" + username + "'");
                return sucesso;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getPontos(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT pontos FROM Utilizador WHERE username='" + username + "'");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getAmigos(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT nome_completo FROM Utilizador WHERE id_utilizador IN (SELECT id_utilizador2 FROM Ligacao WHERE id_utilizador1 IN (SELECT id_utilizador FROM Utilizador WHERE username='"+username+"'))");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getEtiquetas(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT nome FROM Etiqueta WHERE id_etiqueta IN (SELECT id_etiqueta FROM Utilizador_Etiqueta WHERE id_utilizador IN (SELECT id_utilizador FROM Utilizador WHERE username='"+username+"'))");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public int criaEtiqueta(string username, string etiqueta)
        {
            int sucess = 0;

            BeginTransaction();

            try
            {

                ExecuteNonQuery(CurrentTransaction, "INSERT INTO Etiqueta(nome) VALUES ('"+etiqueta+"')");
                ExecuteNonQuery(CurrentTransaction, "INSERT INTO Utilizador_Etiqueta(id_utilizador,id_etiqueta) SELECT (SELECT Utilizador.id_utilizador FROM Utilizador WHERE username='"+username+"') AS id_utilizador,( SELECT Etiqueta.id_etiqueta FROM Etiqueta WHERE nome='"+etiqueta+"') AS id_etiqueta");

                CommitTransaction();
                return sucess;
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getPedidosRecebidos(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT nome_completo FROM Utilizador WHERE id_utilizador IN (SELECT id_utilizador1 FROM PedidoLigacao WHERE id_utilizador2 IN (SELECT id_utilizador FROM Utilizador WHERE username='"+username+"'))");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public DataTable getPedidosFeitos(string username)
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT nome_completo FROM Utilizador WHERE id_utilizador IN (SELECT id_utilizador2 FROM PedidoLigacao WHERE id_utilizador1 IN (SELECT id_utilizador FROM Utilizador WHERE username='"+username+"'))");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }
    }
}
