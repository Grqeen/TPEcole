using Classes.ClassesEcole;
using System;

namespace EcoleTLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TesteAjout();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }

        public static void TesteAjout()
        {
            EtudiantRegulier contact = new EtudiantRegulier(1200, "Gaston Peutimide", 2013, "Systèmes de communication", 6);
            EtudiantRegulier contact1 = new EtudiantRegulier(1204, "Yvan Rattrapeur", 2011, "Systèmes de communication", 2.5);
            EtudiantEchange contact2 = new EtudiantEchange(1345, "Bjorn Borgue", 2012, "informatique", "KTH");
            Enseignant contact3 = new Enseignant(1114, "Mathieu Matheu", 1998, "LMEP", 10000, "Physique");
            Secretaire contact4 = new Secretaire(1409, "Sophie Scribona", 2005, "LMT", 5000);
            EtudiantRegulier temp = new EtudiantRegulier(989898, "Yvsdf", 2011, "ffff", 2.5);

            Ecole ecole = new Ecole("Bona", 2002);

            ecole.ajouterContact(contact);
            ecole.ajouterContact(contact1);
            ecole.ajouterContact(contact2);
            ecole.ajouterContact(contact3);
            ecole.ajouterContact(contact4);

            Console.WriteLine("Parmi " + ecole.nbContacts() + " personnes de l'écoleTLN, " + ecole.nbEtudiant() + " sont des étudiants");
            Console.WriteLine("Ils sont à l'école depuis en moyenne " + ecole.ancienneteMoyenne() +" ans");
            Console.WriteLine("--------- Affichage Tous ----------");
            Console.WriteLine(ecole.afficheTous());
            Console.WriteLine("La moyenne des Etudiants Régulier est de " + ecole.moyenneEtudiantRegulier());
            Console.WriteLine("--------- Ajout d'un contact ----------");
            Console.WriteLine("--------- Ajout d'une collection de contacts ----------");
            Console.WriteLine("--------- Vérifications ----------");
            Console.WriteLine("Nb contacts : " + ecole.nbContacts());
            Console.WriteLine("Le contact existe : " + ecole.existeContact(contact));
            Console.WriteLine("Le contact existe : " + ecole.existeContact(temp));
            Console.WriteLine("Le contact existe : " + ecole.existeContact(1409));
            Console.WriteLine("Le contact existe : " + ecole.existeContact(2222));
        }
    }
}
