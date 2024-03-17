namespace Classes.ClassesEcole
{
    internal class Enseignant : Personnel
    {

        private string section;

        public Enseignant(int matricule, string nom, int anneeArivee, string nomLaboratoire, double salaire, string section) : base(matricule, nom, anneeArivee, nomLaboratoire, salaire)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
            this.section = section;
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tSection : " + this.section;
        }
    }
}
