using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace projetpharmcie2
{  
    
    [Serializable()]
   public class ProdParaPharm:Produit
    {
       
        private string type;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public ProdParaPharm(string Ref, double prix, int qte, string type)
            : base(Ref, prix, qte)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return base.ToString() + "; type :" + this.type;
        }

    }
}
