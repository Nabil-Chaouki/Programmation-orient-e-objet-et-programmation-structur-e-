using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azerty
{
    class errorMois : Error
    {
        private int n;

        public errorMois(string msg,int n):base(msg)
        {
            this.n = n;
        }

        public override string ToString()
        {
            return base.Message + " ,  " + this.n; 
        }
    }
}
