using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace projetpharmcie2
{
    [Serializable()]
   public class Client
    {
       private string nom;

       private string prenom;
       private int chifa;
       private List<Produit> Produis;


       public string Nom
       {
           get
           {
               return nom;
           }

           set
           {
               nom = value;
           }
       }
       public string Prenom
       {
           get
           {
               return prenom;
           }

           set
           {
               prenom = value;
           }
       }
       public int Chifa
       {
           get
           {
               return chifa;
           }

           set
           {
               chifa = value;
           }
       }

       public List<Produit> Produis1
       {
           get
           {
               return Produis;
           }

           set
           {
               Produis = value;
           }
       }

       public Client(string nom, string prenom, int chifa)
       {
           this.nom = nom;
           this.prenom = prenom;
           this.chifa = chifa;
           Produis1 = new List<Produit>();
       }

       public void showMe()
       {
           Console.WriteLine("name :" + this.nom);
           Console.WriteLine("produits :");
           foreach (Produit p in Produis)
           {
               if (p is ProdParaPharm)
                   Console.WriteLine((p as ProdParaPharm).ToString());
               else
                   Console.WriteLine((p as Medicamment).ToString());

           }
       }

       public override string ToString()
       {
           return "nom :" + this.nom + " prenom : " + this.prenom + " chifa : " + this.chifa.ToString();
       }


    

    }
}
