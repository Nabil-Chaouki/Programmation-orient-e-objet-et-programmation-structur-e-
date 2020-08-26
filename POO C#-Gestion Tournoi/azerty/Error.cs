using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azerty
{
    public class Error : Exception
    {
        private chasseur ch;

        public chasseur Ch
        {
            get { return ch; }
            set { ch = value; }
        }

        private DateTime dt;

        public DateTime Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        public Error(string msg):base(msg)
        {

        }

        public Error(string msg , DateTime dt):base(msg)
        {
            this.dt = dt;
        }
        public Error(string msg, chasseur ch):base(msg)
        {
            this.ch = ch;
        }
        public override string ToString()
        {
            string str = base.Message;
            if (this.dt == null) 
            {
                return str;
            }
            if (this.ch != null)
                return str + " , " + ch.ToString();
            return str+" date : "+this.dt.ToShortDateString();
        }

        public string errorChasseur() 
        {
            if (this.ch == null)
            {
                return base.Message;
            }
            return base.Message + " , " + this.ch.ToString();
        }
    }
}
