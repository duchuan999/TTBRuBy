using System;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCDataAdapter : IDisposable
    {
        internal DbDataAdapter adapter;
        internal LTCConnection con;

        public LTCDataAdapter(LTCCommand LTCCmd)
        {
            try
            {
                //string cmdText = LTCCmd.CommandText;
                LTCConnection LTCcon = LTCCmd.cnn;
                //this.adapter = new OracleDataAdapter(cmdText, (OracleConnection)LTCcon.con);
                OracleCommand oraCmd = new OracleCommand(LTCCmd.CommandText, (OracleConnection)LTCcon.con);
                foreach (OracleParameter ltcPar in LTCCmd.Parameters)
                {
                    oraCmd.Parameters.Add(ltcPar.ToString(), ltcPar.Value);
                }
                this.adapter = new OracleDataAdapter(oraCmd);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public LTCDataAdapter(string cmdText, LTCConnection LTCcon)
        {
            this.con = LTCcon;
            try
            {
                this.adapter = new OracleDataAdapter(cmdText, (OracleConnection)LTCcon.con);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Dispose()
        {
            this.adapter = null;
            this.con = null;
        }

        public void Fill(DataTable dt)
        {
            try
            {
                this.adapter.Fill(dt);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Fill(DataSet ds, string tableName)
        {
            try
            {
                this.adapter.Fill(ds, tableName);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Fill(DataSet ds)
        {
            try
            {
                this.adapter.Fill(ds);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Update(DataTable tbl)
        {
            try
            {
                this.adapter.Update(tbl);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Update(DataSet ds, string tableName)
        {
            try
            {
                this.adapter.Update(ds, tableName);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public LTCCommand DeleteCommand
        {
            get
            {
                if (((OracleDataAdapter)this.adapter).DeleteCommand != null)
                {
                    return new LTCCommand(((OracleDataAdapter)this.adapter).DeleteCommand);
                }
                return null;
            }
            set
            {
                ((OracleDataAdapter)this.adapter).DeleteCommand = (OracleCommand)value.cmd;
            }
        }

        public LTCCommand InsertCommand
        {
            get
            {
                if (((OracleDataAdapter)this.adapter).InsertCommand != null)
                {
                    return new LTCCommand(((OracleDataAdapter)this.adapter).InsertCommand);
                }
                return null;
            }
            set
            {
                ((OracleDataAdapter)this.adapter).InsertCommand = (OracleCommand)value.cmd;
            }
        }

        public LTCCommand SelectCommand
        {
            get
            {
                if (((OracleDataAdapter)this.adapter).SelectCommand != null)
                {
                    return new LTCCommand(((OracleDataAdapter)this.adapter).SelectCommand);
                }
                return null;
            }
            set
            {
                ((OracleDataAdapter)this.adapter).SelectCommand = (OracleCommand)value.cmd;
            }
        }

        public LTCCommand UpdateCommand
        {
            get
            {
                if (((OracleDataAdapter)this.adapter).UpdateCommand != null)
                {
                    return new LTCCommand(((OracleDataAdapter)this.adapter).UpdateCommand);
                }
                return null;
            }
            set
            {
                ((OracleDataAdapter)this.adapter).UpdateCommand = (OracleCommand)value.cmd;
            }
        }
    }
    
}
