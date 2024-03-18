using System;
using static System.Collections.Specialized.BitVector32;

namespace Classes.ClassesEcole
{
    internal class Contact
    {

        protected int matricule;
        protected string nom;
        protected int anneeArivee;

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneeArivee { get => anneeArivee; 
            set
            {
                if (value <= DateTime.Now.Year)
                {
                    anneeArivee = value;
                }
                else
                {
                    throw new Exception("L'année ne peux etre inférieur a l'année actuel");
                }
            }
                
                }

        public Contact(int matricule, string nom, int anneeArivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.AnneeArivee = anneeArivee;
        }

        public override string ToString()
        {
            return "Etudiant : " + "\n\tMatricule : " + this.matricule + "\n\tNom : " + this.nom + "\n\tAnnée :" + this.anneeArivee + "\n\tSection : ";
        }

    }
}
