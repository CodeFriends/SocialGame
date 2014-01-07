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
    public abstract class BaseGateway
    {
        public BaseGateway()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //alteradas as connectionStrings
        private const string _CONNSTR = @"Data Source=gandalf.dei.isep.ipp.pt\sqlexpress;Initial Catalog=ARQSI104;UserID=ARQSI104;Password=Code5!";

        private string CONNSTR
        {
            get
            {
                //return System.Configuration.ConfigurationSettings.AppSettings["ConnStr"];
                return _CONNSTR;
            }
        }

        private SqlTransaction myTx;

        protected SqlTransaction CurrentTransaction
        {
            get { return myTx; }
        }

        protected SqlConnection GetConnection(bool open)
        {
            SqlConnection cnx = new SqlConnection(CONNSTR);
            if (open)
                cnx.Open();
            return cnx;
        }

        protected DataSet ExecuteQuery(SqlConnection cnx, string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        protected void FillDataSet(SqlConnection cnx, string sql, DataSet ds, string tableName)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cnx);
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        protected int ExecuteNonQuery(SqlConnection cnx, string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnx);
            return cmd.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(SqlTransaction tx, string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, tx.Connection, tx);
            return cmd.ExecuteNonQuery();
        }

        protected int ExecuteNonQuery(SqlTransaction tx, SqlCommand cmd)
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
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public void CommitTransaction()
        {
            if (myTx != null)
            {
                SqlConnection cnx = myTx.Connection;
                myTx.Commit();
                cnx.Close();
            }
        }

        public void RollbackTransaction()
        {
            if (myTx != null)
            {
                SqlConnection cnx = myTx.Connection;
                myTx.Rollback();
                cnx.Close();
            }
        }
    }
}
