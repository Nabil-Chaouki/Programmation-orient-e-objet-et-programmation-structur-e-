using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace azerty
{
    [Serializable()]
    public class tournoi 
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private DateTime dt;

        public DateTime Dt
        {
            get { return dt; }
            set { dt = value; }
        }


        List<chasseur> lstchasseur;

        public List<chasseur> Lstchasseur
        {
            get { return lstchasseur; }
            set { lstchasseur = value; }
        }
       


        public tournoi(string nom , DateTime dt)
        {
            this.nom = nom;
            this.dt = dt;
            lstchasseur= new List<chasseur>();
            
        }

        public void inscrire(string licence, string nom, DateTime dt) 
        {
            if (this.lstchasseur.Count > 3) throw new Error("lista est fermer");
            if (this.recherc(licence) != -1) throw new Error("ce chasseur existe deja",this.recher(licence));

            this.lstchasseur.Add(new chasseur(licence,nom,dt));

        }
        
        public int recherc(string n)
        {
            for (int i = 0; i < lstchasseur.Count; i++) 
            {
                if (this.lstchasseur[i].Equals(n)) 
                {
                    return i;
                }

            }
            return -1;
        }

        public chasseur recher(string n)
        {
            foreach (chasseur c in lstchasseur) 
            {
                if (c.Equals(n)) 
                {
                    return c;
                }
            }
            return null;
        }

        public chasseur meuilleurNbj(string moi) 
        {
            int temp=0;
            chasseur chh = null;
            foreach (chasseur ch in this.lstchasseur) 
            {
                if (ch.scoreMois(moi) > temp)
                {
                    temp += ch.scoreMois(moi);
                    chh = ch;
                }
            }
            return chh;
        }

        public List<chasseur> classementMensuel(string mois)
        {
            //List<chasseur> l = this.lstchasseur;// un objet declare fach katafecti lih kaytbdal l=lstchasseur kaytbdl lst achsseu
            List<chasseur> l = new List<chasseur>();
            l = this.Lstchasseur;
            l.AddRange(lstchasseur);
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {

                    if(l[i].scoreMois(mois)<l[j].scoreMois(mois)){
                        chasseur temp=l[i];
                        l[i]=l[j];
                        l[j]=temp;
                    }
                }
            }
            return l;
        }

    }


}
