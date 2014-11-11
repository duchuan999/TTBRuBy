using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCGetType
    {
        /// <summary>
        /// Bool = 1,
        /// Date = 2,
        /// Decimal = 3,
        /// Int = 4,
        /// NVarChar = 5,
        /// VarChar = 6
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static OracleDbType GetType(LTCType type)
        {
            switch (((int)type))
            {
                case 1:
                    return OracleDbType.Int16;

                case 2:
                    return OracleDbType.Date;

                case 3:
                    return OracleDbType.Decimal;

                case 4:
                    return OracleDbType.Int64;

                case 5:
                    return OracleDbType.NVarchar2;

                case 6:
                    return OracleDbType.Varchar2;

                case 7:
                    return OracleDbType.Blob;
            }
            throw new Exception();
        }
    }
}
