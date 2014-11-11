using System;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace LTCAccessdata
{
    public class LTCException : Exception
    {
        string message;
        Exception systemException;

        public LTCException(Exception e, string msg)
        {
            this.message = e.ToString()+msg;
            LogError();
        }

        public void LogError()
        {
            string str = "";
            str = "Log" + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString() + ".txt";
            FileStream stream = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.BaseStream.Seek(0L, SeekOrigin.End);
            writer.WriteLine("");
            writer.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Today.ToLongDateString());
            if (this.systemException != null)
            {
                writer.WriteLine(this.message + this.systemException.Message);
                writer.WriteLine(this.systemException.Source);
                writer.WriteLine(this.systemException.StackTrace);
            }
            else
            {
                writer.WriteLine(this.message);
            }
            writer.Flush();
            stream.Close();
        }

        public string LTCMessage
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        public override string ToString()
        {
            return this.message;
        }
    }
}
