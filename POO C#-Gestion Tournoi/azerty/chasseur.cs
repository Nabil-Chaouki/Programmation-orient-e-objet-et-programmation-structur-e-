using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace azerty
{
    [Serializable()]
    public class chasseur : IComparable<chasseur>
    {
        private string licence;

        public string Licence1
        {
            get { return licence; }
            set { licence = value; }
        }
        private string nom;

        public string Nom1
        {
            get { return nom; }
            set { nom = value; }
        }
        private DateTime dt;

        public DateTime Dt1
        {
            get { return dt; }
            set { dt = value; }
        }
        private List<score> lstsc;

        public List<score> Lstsc1
        {
            get { return lstsc; }
            set { lstsc = value; }
        }
        


        public List<score> Lstsc
        {
            get { return lstsc; }
            set { lstsc = value; }
        }
        public DateTime Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Licence
        {
            get { return licence; }
            set { licence = value; }
        }

        public chasseur(string licence, string nom, DateTime dt)
        {
            if ((DateTime.Now.Year - dt.Year) < 18) throw new Error("date uncorrect ",dt);
            this.licence = licence;
            this.nom = nom;
            this.dt = dt;
            this.lstsc = new List<score>();
            this.init();
        }
        public chasseur()
        {

        }
        public void init()
        {
            //lstsc.Add(new score(1) { Nbj = 5 });

            for (int i = 5; i <= 12; i++)
            {
                lstsc.Add(new score(i));
            }
        }
        
        public override string ToString()
        {
            return "licenc :" + this.licence + ", nom :" + this.nom + ", date de naissance :" + this.dt.ToShortDateString();
        }


        public void enregistre(int n , int nbj) 
        {
            //if (score.mois(n) == "incorecct" && ) throw new Exception("eazaze");

            foreach (score s in lstsc) 
            {
                if (s.N < n && s.Nbj == -1) throw new errorMois("aazaze",s.N);

                if (s.N == n /*&& n>5 && lstsc[n - 6].Nbj != -1 */) 
                {
                    s.Nbj = nbj;
                    break;
                }
                
            }
            
            //lstsc[n].Nbj = nbj;

        }

        public int actScr() 
        {
            int k=0;
            foreach (score s in lstsc)
            {
                if (s.Nbj == -1)
                    break;

                k += s.Nbj;
            }
            return k;
        }

        public int scoreMois(string mois) 
        {
            int n = score.numMois(mois);
           // int temp;
            for (int i = 0; i < lstsc.Count; i++) 
            {
                if (this.lstsc[i].N == n) 
                {
                    return this.lstsc[i].Nbj;
                }
            }
            return -1;
        }

        public override bool Equals(object obj)
        {
            if(obj is  chasseur)
                return (obj as chasseur).licence==this.licence;
            
                return (string)obj == this.licence;
        }

        public int CompareTo(chasseur obj)
        {
            return string.Compare(this.nom, obj.nom);
               
        }
    }
}
