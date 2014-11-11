using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCCommand : IDisposable
    {
        internal IDbCommand cmd;
        public LTCConnection cnn;
        private string commandText;

        internal LTCCommand(IDbCommand cmd)
        {
            try
            {
                this.cmd = cmd;
                this.commandText = this.cmd.CommandText;
                this.cnn = new LTCConnection(this.cmd.Connection);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, this.cmd.CommandText + exception.Message);
            }
        }

        public LTCCommand(string cmdText, LTCConnection LTCcnn)
        {
            try
            {
                this.commandText = cmdText;
                this.cnn = LTCcnn;
                this.cmd = new OracleCommand(this.commandText, (OracleConnection)LTCcnn.con);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Dispose()
        {
            this.cnn = null;
            this.commandText = null;
            if (this.cmd != null)
            {
                this.cmd.Dispose();
                this.cmd = null;
            }
        }

        public int ExecuteNonQuery()
        {
            int i_Val = 0;
            try
            {
                i_Val = this.cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, this.cmd.CommandText);
            }
            return i_Val;
        }

        public LTCDataReader ExecuteReader()
        {
            LTCDataReader reader = null ;
            try
            {
                reader = new LTCDataReader(this.cmd.ExecuteReader());
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, this.cmd.CommandText);
            }
            return reader;
        }

        public object ExecuteScalar()
        {
            object obj2=null;
            try
            {
                obj2 = this.cmd.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, this.cmd.CommandText);
            }
            return obj2;
        }

        public string CommandText
        {
            get { return this.cmd.CommandText; }
            set
            {
                this.cmd.CommandText = value;
            }
        }

        public int CommandTimeout
        {
            get
            {
                return this.cmd.CommandTimeout;
            }
            set
            {
                this.cmd.CommandTimeout = value;
            }
        }

        public System.Data.CommandType CommandType
        {
            get
            {
                return this.cmd.CommandType;
            }
            set
            {
                this.cmd.CommandType = value;
            }
        }

        public LTCConnection Connection
        {
            set
            {
                this.cmd.Connection = value.con;
            }
        }

        public LTCParameterCollection Parameters
        {
            get
            {
                LTCParameterCollection parameters;
                try
                {
                    parameters = new LTCParameterCollection(this.cmd.Parameters);
                }
                catch (Exception exception)
                {
                    throw new LTCException(exception, this.cmd.CommandText);
                }
                return parameters;
            }
        }

        public LTCTransaction Transaction
        {
            get
            {
                LTCTransaction transaction=null;
                try
                {
                    transaction = new LTCTransaction(this.cmd.Transaction);
                }
                catch (Exception exception)
                {
                    throw new LTCException(exception, this.cmd.CommandText);
                }
                return transaction;
            }
            set
            {
                this.cmd.Transaction = value.trans;
            }
        }
    }
    
}
