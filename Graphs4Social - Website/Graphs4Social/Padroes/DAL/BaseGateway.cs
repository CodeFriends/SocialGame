using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Padroes.DAL
{
    public abstract class BaseGateway
    {
        public BaseGateway()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //alteradas as connectionStrings
        private const string _CONNSTR = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|revenuerecognitions.mdb;";
        private string CONNSTR
        {
            get
            {
                //return System.Configuration.ConfigurationSettings.AppSettings["ConnStr"];
                return _CONNSTR;
            }
        }

        private OleDbTransaction myTx;

        protected OleDbTransaction CurrentTransaction
        {
            get { return myTx; }
        }

        protected OleDbConnection GetConnection(bool open)
        {
            OleDbConnection cnx = new OleDbConnection(CONNSTR);
            if (open)
                cnx.Open();
            return cnx;
        }

        protected DataSet ExecuteQuery(OleDbConnection cnx, string sql)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(sql, cnx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        protected void FillDataSet(OleDbConnection cnx, string sql, DataSet ds, string tableName)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(sql, cnx);
                da.Fill(ds, tableName);
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        protected int ExecuteNonQuery(OleDbConnection cnx, string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, cnx);
            return cmd.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(OleDbTransaction tx, string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, tx.Connection, tx);
            return cmd.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(OleDbTransaction tx, OleDbCommand cmd)
        {
            cmd.Transaction = tx;
            return cmd.ExecuteNonQuery();
        }

        public void BeginTransaction()
        {
            try
            {
                if (myTx == null)
                    myTx = GetConnection(true).BeginTransaction();
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public void CommitTransaction()
        {
            if (myTx != null)
            {
                OleDbConnection cnx = myTx.Connection;
                myTx.Commit();
                cnx.Close();
            }
        }

        public void RoolbackTransaction()
        {
            if (myTx != null)
            {
                OleDbConnection cnx = myTx.Connection;
                myTx.Rollback();
                cnx.Close();
            }
        }
    }
}