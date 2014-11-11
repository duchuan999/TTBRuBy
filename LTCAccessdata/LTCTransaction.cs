using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCTransaction
    {
        internal IDbTransaction trans;

        internal LTCTransaction(IDbTransaction trans)
        {
            this.trans = trans;
        }

        public void Commit()
        {
            try
            {
                ((OracleTransaction)this.trans).Commit();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Rollback()
        {
            try
            {
                ((OracleTransaction)this.trans).Rollback();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }
    }
}
