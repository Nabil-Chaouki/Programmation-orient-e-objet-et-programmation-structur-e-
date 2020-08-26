using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj129
{
    public class Etudient : Persone
    {
        private string classe;

        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }


        public Etudient(string nom, string prenom, int age, string classe)
            : base(nom, prenom, age)
        {
            this.classe = classe;
        }
    }
}
