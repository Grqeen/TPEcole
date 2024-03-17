using System.Collections.Generic;

namespace Classes.ClassesEcole
{
    internal class Ecole
    {
        private string nom;
        private int anneCreation;
        private Dictionary<int, Contact> contacts;

        public Ecole(string nom, int anneCreation)
        {
            this.nom = nom;
            this.anneCreation = anneCreation;
            this.contacts = new Dictionary<int, Contact>();
        }

        public string afficheTous()
        {
            string temp = "";
            foreach (Contact contact in contacts.Values)
            {
                 temp += contact.ToString() + "\n";
            }
            return temp;
        }

        public double ancienneteMoyenne()
        {
            return 111;

        }

        public bool estEtudiant(Contact contact)
        {

            return contact is Etudiant;


        }

        public int nbContacts()
        {
            return contacts.Count;
        }

        public double moyenneEtudiantRegulier()
        {

            return 1111;

        }

        public void ajouterContact(Contact contact)
        {
            contacts.Add(contact.Matricule, contact);
        }

        public int nbEtudiant()
        {
            int nbetudiant = 0;
            foreach (Contact etudiant in contacts.Values)
            {
                if (estEtudiant(etudiant))
                {
                    nbetudiant++;
                }
            }
            return nbetudiant;
        }

        public bool existeContact(Contact contactee)
        {
            foreach (Contact contact in contacts.Values)
            {
                if (contact == contactee)
                {
                    return true;
                }
            }
            return false;
        }

        public bool existeContact(int matricule)
        {
            foreach (int matri in contacts.Keys)
            {
                if (matricule == matri)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
