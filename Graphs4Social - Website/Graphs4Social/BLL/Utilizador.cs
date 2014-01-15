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

        public DataTable getEtiquetas(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getEtiquetas(username);
        }

        public int criaEtiqueta(string username, string etiqueta)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.criaEtiqueta(username, etiqueta);
        }
        
        public int associaEtiquetaAutilizador(string username, string etiqueta)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.associaEtiquetaAutilizador(username, etiqueta);
        }

        public DataTable getPedidosRecebidos(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getPedidosRecebidos(username);
        }

        public DataTable getPedidosFeitos(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getPedidosFeitos(username);
        }

        public int aceitaPedidoAmizade(string username, string nomeDeQuemFezPedido,int forca, string tagRelacao)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.aceitaPedidoAmizade(username, nomeDeQuemFezPedido, forca, tagRelacao);
        }

        public DataTable top10Pontos()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.top10Pontos();
        }

        public DataTable top10Forca()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.top10Forca();
        }

        public DataTable top10Dimensao()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.top10Dimensao();
        }

        public DataTable getRankForca(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getRankForca(username);
        }

        public DataTable getTotalForca(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getTotalForca(username);
        }

        public DataTable getRankDimensao(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getRankDimensao(username);
        }

        public int criaPedido(string username, string nome)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.criaPedido(username, nome);
        }

        public int eliminaAmigo(string username,string nome)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.eliminaAmigo(username,nome);
        }

        public int eliminaPedidoAmizade(string username, string nomeAquemPediuAmizade)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.eliminaPedidoAmizade(username, nomeAquemPediuAmizade);
        }

        public int recusaPedidoAmizade(string username, string nomeDeQuemFezPedido)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.recusaPedidoAmizade(username, nomeDeQuemFezPedido);
        }

        public DataTable verPerfil(string nome)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.verPerfil(nome);
        }

        public int eliminaTag(string username, string tag)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.eliminaTag(username, tag);
        }

        public DataTable getTagRelacao(string username)
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.getTagRelacao(username);
        }

        public DataTable utilizadoresExistentes()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.utilizadoresExistentes();
        }

        public DataTable cloudUtilizadores()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.cloudUtilizadores();
        }

        public DataTable cloudRelacoes()
        {
            DAL.UtilizadorGateway dal = new DAL.UtilizadorGateway();
            return dal.cloudRelacoes();
        }
        
    }
}
