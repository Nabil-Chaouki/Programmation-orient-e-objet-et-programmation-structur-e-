using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace projetpharmcie2
{
    [Serializable()]
  public  class Produit{

      private string Ref;

      public string Ref1
      {
          get { return Ref; }
          set { Ref = value; }
      }
      private double prix;

      public double Prix
      {
          get { return prix; }
          set { prix = value; }
      }
      private int qte;

      public int Qte
      {
          get { return qte; }
          set { qte = value; }
      }
      public Produit(string Ref, double prix, int qte)
      {
          this.Ref = Ref;
          this.prix = prix;
          this.qte = qte;
      }


      public bool Equals(Produit obj)
      {
          if (this.Ref == obj.Ref && this.prix == obj.prix && this.qte == obj.qte) return true;
          return false;
      }

      public override string ToString()
      {
          return "Reference :" + this.Ref + "; Prix : " + this.prix + "; QTE : " + this.qte;
      }
    }
}
