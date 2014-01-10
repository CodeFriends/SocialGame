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

        public DataTable getUtilizadoresDisponiveis(string nome)
        {
            DAL.UtilizadorGateway lista = new DAL.UtilizadorGateway();
            return lista.getUtilizadoresDisponiveis(nome);
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

        public DataTable getEstados()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getEstados();
        }

        public DataTable getIDEstadoHumor(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getIDEstadoHumor(username);
        }

        public DataTable getImagemEstado(int idEstado)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getImagemEstado(idEstado);
        }

        public string verificaEstadoHumor(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.verificaEstadoHumor(username);
        }

        public DataTable selecionaIdEstado(string estadoH)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.selecionaIdEstado(estadoH);
        }

        public int actualizaEstado(string username, int idEstadoHumor)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.actualizaEstado(username,idEstadoHumor);
        }

        public DataTable getPontos(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getPontos(username);
        }

        public DataTable getAmigos(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getAmigos(username);
        }
    }
}
