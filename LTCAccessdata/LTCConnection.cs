using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCConnection
    {
        internal IDbConnection con;
        public string connstring;

        internal LTCConnection(IDbConnection con)
        {
            try
            {
                this.con = con;
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public LTCConnection(string connectionString)
        {
            try
            {
                this.connstring = connectionString;
                this.con = new OracleConnection(connectionString);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public LTCTransaction BeginTransaction()
        {
            LTCTransaction transaction=null;
            try
            {
                transaction = new LTCTransaction(this.con.BeginTransaction());
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
            return transaction;
        }

        public void Close()
        {
            try
            {
                if (con != null)
                {
                    this.con.Close();
                    this.con.Dispose();
                    this.con = null;
                }
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Dispose()
        {
            try
            {
                this.con.Dispose();
            }
            catch 
            {
            }
        }

        public void Open()
        {
            try
            {
                this.con.Open();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public override string ToString()
        {
            return this.connstring;
        }
    }
}
