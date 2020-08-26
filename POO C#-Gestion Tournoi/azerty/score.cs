using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azerty
{
    [Serializable()]
    public class score
    {
        private int n;
        private int nbj;

        public int Nbj
        {
            get { return nbj; }
            set { nbj = value; }
        }

        
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public score(int n )
        {
            this.n = n;
            this.nbj = -1;
        }

        public static string mois(int n)
        {
            switch (n) 
            {
                case 5 :
                    return "mai";
                case 6 :
                    return "juin";
                case 7 :
                    return "juillet";
                case 8:
                    return "aout";
                case 9:
                    return "septembre";
                case 10:
                    return "octobre";
                case 11:
                    return "novembre";
                case 12:
                    return "decembre";
            }
            return "incorecct";
        }

        public static int numMois(string mois) 
        {
            string[] mois1 = { "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };
            for (int i = 0; i < mois1.Length; i++) 
            {
                if (mois1[i].CompareTo(mois) == 0) 
                {
                    return i + 5;
                }
            }
            return -1;

        }

        public static string mois2(int n) 
        {
            string[] mois = { "mai", "juin" ,"juillet" ,"aout" ,"septembre" ,"octobre" ,"novembre" ,"decembre"};
            return mois[n - 5];
        }

        public override string ToString()
        {
            return "mois :" + this.n + " , nbj :" + this.nbj;
        }
        public override bool Equals(object obj)
        {
            return (obj as score).n == this.n;
              
        }
    }
}
