using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace projetpharmcie2
{
    [Serializable()]
  public  class Medicamment:Produit
    {
        private bool generique;
        private bool ordonnace;

        public bool Generique
        {
            get
            {
                return generique;
            }

            set
            {
                generique = value;
            }
        }
        public bool Ordonnace
        {
            get
            {
                return ordonnace;
            }

            set
            {
                ordonnace = value;
            }
        }

        public Medicamment(string Ref, double prix, int qte, bool generique, bool ordonnace)
            : base(Ref, prix, qte)
        {
            this.generique = generique;
            this.ordonnace = ordonnace;
        }

        public override string ToString()
        {
            return base.ToString() + "; generique :" + generique.ToString() + "; ordannace :" + ordonnace.ToString();
        }

    }
}
