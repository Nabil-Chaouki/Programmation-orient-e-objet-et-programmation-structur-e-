using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//aze
namespace azerty
{
    [Serializable()]
    class Program
    {
        public static int nc = 5;

        static void Main(string[] args)
        {
            

            try
            {


                tournoi tr;
                int choix = 0;
                do
                {
                    Console.WriteLine("1-nv tournoi");
                    Console.WriteLine("2- ouvrire fichier ou tournoi ");
                    Console.WriteLine("3-quitte");
                    choix = int.Parse(Console.ReadLine());
                    switch (choix)
                    {
                        case 1:
                            {
                                Console.WriteLine("entrez le nom de tournoi");
                                string nomDeTournoi = Console.ReadLine();
                                DateTime dt = DateTime.Now;
                                tr = new tournoi(nomDeTournoi, dt);
                                if(File.Exists(nomDeTournoi)) throw new Error("ce fichier  existe deja");
                                


                                Program.menu(tr);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("enter le nom de tournoi a ouvrir");
                                string nom = Console.ReadLine().ToUpper();
                                if (!File.Exists(nom)) throw new Error("le fichier exist");

                                FileStream fs = new FileStream(nom, FileMode.Open);
                                BinaryFormatter bf = new BinaryFormatter();
                                tr = (tournoi)bf.Deserialize(fs);
                                fs.Close();
                                Program.menu(tr);
                                break;
                            }
                        case 3: {
                            Environment.Exit(0);
                            break;
                             }
                    }
                } while (choix != 3);




            }

            
            catch (Error err)
            {

                Console.WriteLine(err.ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void menu(tournoi tr) 
        {
            //tr = new tournoi("Tournoi", new DateTime(2019, 5, 2));
            chasseur ch = new chasseur(); 
            int choix = 0;
            do{
                Console.WriteLine("************************************");
                Console.WriteLine("1- inscrire");
                Console.WriteLine("2- affiche");
                Console.WriteLine("3- enregistre score");
                Console.WriteLine("4 score du mois");
                Console.WriteLine("5-supprimer un chasseur");
                Console.WriteLine("6- revenir");
                Console.WriteLine("*****************************");
                choix = int.Parse(Console.ReadLine());
                try {
                switch(choix)
                {
                    case 1: 
                        {
                            Console.WriteLine("entrez licence");
                            ch.Licence = Console.ReadLine().ToUpper();
                            if (tr.recher(ch.Licence) != null) throw new Error("exist deja");
                            Console.WriteLine("enterz le nom");
                            ch.Nom = Console.ReadLine().ToUpper();
                            Console.WriteLine("enterz date de naissance : aaaa/mm/jj");
                            DateTime dt = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                            ch.Dt =  dt;//DateTime.Parse(Console.ReadLine());
                            tr.inscrire(ch.Licence, ch.Nom, ch.Dt);
                            Console.WriteLine("le chasseur a ete inscrit");
                            break;
                        }
                    case 2: 
                        {
                            List<chasseur> lc = tr.Lstchasseur;
                            for (int i = 0; i < lc.Count; i++) 
                            {
                                Console.WriteLine(lc[i]+ " score total actuel :" + lc[i].actScr());
                                Console.WriteLine("list des score");
                                for (int j = 0; j < lc[i].Lstsc.Count; j++) 
                                {
                                    Console.WriteLine(lc[i].Lstsc[j]);
                                }
                                Console.WriteLine("***************************");
                            }
                                break;
                        }
                    case 3: 
                        {
                            if (tr.Lstchasseur.Count < 3) throw new Error("la list nest pas encore valide");
                            List<chasseur> l =tr.Lstchasseur;
                            for (int i = 0; i < l.Count; i++) 
                            
                            {
                                Console.WriteLine("entrez le nombre de gibi pour le moin:"+nc+" du chasseur :"+l[i]);
                                int nbj = int.Parse(Console.ReadLine());
                                l[i].enregistre(nc, nbj);
                                
                            }
                            nc++;
                                break;
                        }
                    case 4:
                        {
                            Console.WriteLine( "mois de ?");
                            string Mm = Console.ReadLine();
                            int num = score.numMois(mois);

                            chasseur c = tr.Lstchasseur[0];

                            for (int i = 0; i < c.Lstsc.Count; i++)
                            {
                                if ((c.Lstsc[i].N == num)&&(c.Lstsc[i].Nbj==-1))
                                {
                                    throw new Error("ce mois n apas ete encore enregistre");
                                }

                                
                            }
                            List<chasseur> lsttrie = tr.classementMensuel(Mm);
                            foreach (chasseur k in lsttrie)
                            {
                                Console.WriteLine(k);

                            }

                        }


                        break;
                case 5:{
                    Console.WriteLine("Lisence:?");
                    int i = tr.recherc(Console.ReadLine());
                    if (i != -1)
                    {
                        Console.WriteLine("etes vous sur de vouloir eliminer ce chasseur o/n:"+tr.Lstchasseur[i]);
                        Console.WriteLine("apuyyer sur o pour confirmer et n pour annule");
                        char rep = char.Parse(Console.ReadLine());
                        if(rep!='o' ){

                            throw new Error("suppresseion annule");
                            tr.Lstchasseur.RemoveAt(i);

                        }
                        throw new Error("ce chasseur n existe pas ");




                           















                    }
                    
                    



                        break;
                    } 
                    case 6:

{
                        FileStream fs = new FileStream(tr.Nom,FileMode.Create);

                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, tr);
                        fs.Close();
                        tr = null;


                        
                        
}
break;


                        
                    default :
                        {
                            Console.WriteLine("choix uncorrect");
                            break;
                        }
                }
                }
                catch(Error er) {Console.WriteLine(er.Message);}
                catch(Exception ex){Console.WriteLine(ex.Message);}
            }while(choix != 6);
        }


        public static string mois { get; set; }
    }
}
