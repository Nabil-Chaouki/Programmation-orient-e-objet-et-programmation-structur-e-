using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace projetpharmcie2
{
    [Serializable()]
   public class Pharmacie
    {
        private string nom;
        private string adresse;

        private Dictionary<int,Client> Clients;
        private Dictionary<string,Produit> Produits;


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
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public Dictionary<int, Client> Clients1
        {
            get
            {
                return Clients;
            }

            set
            {
                Clients = value;
            }
        }

        public Dictionary<string, Produit> Produits1
        {
            get
            {
                return Produits;
            }

            set
            {
                Produits = value;
            }
        }

        

        public Pharmacie(string nom,string adresse)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.Clients = new Dictionary<int, Client>();
            this.Produits = new Dictionary<string, Produit>();

        }

       

        public void achat(Client c , Produit p , int qte)
        {
            Client cl=c;

            if (this.Clients.ContainsKey(c.Chifa))
            {
                if(Clients[c.Chifa].Nom==c.Nom && Clients[c.Chifa].Prenom == c.Prenom)
                {
                    cl = Clients[c.Chifa];
                }
                else
                {
                    throw new Exception("le nom ou prenom invalide de cette code de chifa");
                }
            }
                
            else
                this.Clients.Add(c.Chifa, c);
           

            if(!this.Produits.ContainsKey(p.Ref1)) throw new Exception("ce produitne existe pas");
            

            Produits[p.Ref1].Qte -= qte;
            
                    
                        if (p is Medicamment)
                        {
                            
                            Medicamment m = p as Medicamment;
                            cl.Produis1.Add(new Medicamment(p.Ref1, p.Prix, qte,m.Generique,m.Ordonnace));
                            
                        }
                        else
                        {
                            ProdParaPharm pr = p as ProdParaPharm;
                            cl.Produis1.Add(new ProdParaPharm(p.Ref1, p.Prix, qte,pr.Type));
                        }
                    
                    
        }

        public void approvisionnementDuStock(Produit p , int qte)
        {
            if(!this.Produits.ContainsKey(p.Ref1)) throw new Exception("le produit ne existe pas");

                Produits[p.Ref1].Qte += qte;
        }

        public void afficheClients()
        {
            foreach (KeyValuePair<int,Client> c in Clients)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void afficheProduits()
        {
            foreach (KeyValuePair<string,Produit> p in Produits)
            {
                if(p.Value is ProdParaPharm)
                     Console.WriteLine((p.Value as ProdParaPharm).ToString());
                else
                    Console.WriteLine((p.Value as Medicamment).ToString());
                
            }
        }

        

    }

    }

