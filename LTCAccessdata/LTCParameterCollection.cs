using System;
using System.Collections;
using System.Data;
using System.Reflection;
using Oracle.DataAccess.Client;

namespace LTCAccessdata
{
    public class LTCParameterCollection : IDataParameterCollection, IList, ICollection, IEnumerable
    {
        internal IDataParameterCollection paramCols;

        internal LTCParameterCollection(IDataParameterCollection paramCols)
        {
            this.paramCols = paramCols;
        }

        public int Add(object value)
        {
            int num=0;
            try
            {
                num = this.paramCols.Add(value);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
            return num;
        }

        public LTCParameter Add(string paraName, LTCType LtcType, int size)
        {
            LTCParameter parameter = null;
            try
            {
                parameter = new LTCParameter(((OracleParameterCollection)this.paramCols).Add(paraName, LTCGetType.GetType(LtcType), size));
            }
            catch //(LTCException exception)
            {
                parameter = null;
            }
            return parameter;
        }

        public LTCParameter Add(string paraName, LTCType LtcType, int size, string sourceColumn)
        {
            LTCParameter parameter = null;
            try
            {
                parameter = new LTCParameter(((OracleParameterCollection)this.paramCols).Add(paraName, LTCGetType.GetType(LtcType), size, sourceColumn));
            }
            catch 
            {
                parameter = null;
            }
            return parameter;
        }

        public void Clear()
        {
            try
            {
                this.paramCols.Clear();
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public bool Contains(object value)
        {
            return this.paramCols.Contains(value);
        }

        public bool Contains(string value)
        {
            return this.paramCols.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            this.paramCols.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return this.paramCols.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            return this.paramCols.IndexOf(value);
        }

        public int IndexOf(string value)
        {
            return this.paramCols.IndexOf(value);
        }

        public void Insert(int i, object value)
        {
            try
            {
                this.paramCols.Insert(i, value);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void Remove(object value)
        {
            try
            {
                this.paramCols.Remove(value);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void RemoveAt(int i)
        {
            try
            {
                this.paramCols.RemoveAt(i);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public void RemoveAt(string i)
        {
            try
            {
                this.paramCols.RemoveAt(i);
            }
            catch (Exception exception)
            {
                throw new LTCException(exception, exception.Message);
            }
        }

        public int Count
        {
            get
            {
                return this.paramCols.Count;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return true;
            }
        }

        public object this[int i]
        {
            get
            {
                object obj2=null;
                try
                {
                    obj2 = new LTCParameter((IDbDataParameter)this.paramCols[i]);
                }
                catch (Exception exception)
                {
                    throw new LTCException(exception, exception.Message);
                }
                return obj2;
            }
            set
            {
                this.paramCols[i] = ((LTCParameter)value).para;
            }
        }

        public object this[string i]
        {
            get
            {
                object obj2=null;
                try
                {
                    obj2 = new LTCParameter((IDbDataParameter)this.paramCols[i]);
                }
                catch (Exception exception)
                {
                    throw new LTCException(exception, exception.Message);
                }
                return obj2;
            }
            set
            {
                this.paramCols[i] = ((LTCParameter)value).para;
            }
        }

        public object SyncRoot
        {
            get
            {
                return null;
            }
        }
    }
}
