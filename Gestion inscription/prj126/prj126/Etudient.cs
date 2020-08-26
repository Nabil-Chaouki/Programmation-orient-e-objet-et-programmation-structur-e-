using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj126
{
    [Serializable]

    public class Etudient
    {
        private int ide;

        public int Ide
        {
            get { return ide; }
            set { ide = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private DateTime dn;

        public DateTime Dn
        {
            get { return dn; }
            set { dn = value; }
        }
        private string bac;

        public string Bac
        {
            get { return bac; }
            set { bac = value; }
        }
        private string sec;

        public string Sec
        {
            get { return sec; }
            set { sec = value; }
        }
        private double note;

        public double Note
        {
            get { return note; }
            set { note = value; }
        }

        public Etudient(int ide)
        {
            this.ide = ide;
        }

        public Etudient(int ide,string nom,DateTime dn,string bac,string sec,double note)
        {
            this.ide = ide;
            this.nom = nom;
            this.dn = dn;
            this.bac = bac;
            this.sec = sec;
            this.note = note;
        }
        
        public override bool Equals(object obj)
        {
            Etudient e = (Etudient)obj;
            return (this.ide == e.ide);
        }
    }
}
