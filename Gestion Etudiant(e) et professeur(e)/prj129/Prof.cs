using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj129
{
    public class Prof : Persone
    {
        private string mat;

public string Mat
{
  get { return mat; }
  set { mat = value; }
}

        public Prof(string nom, string prenom, int age, string mat)
            : base(nom, prenom, age)
        {
            this.mat = mat;
        }
    }
}
