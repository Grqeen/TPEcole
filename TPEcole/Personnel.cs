namespace Classes.ClassesEcole
{
    internal class Personnel : Contact
    {

        protected string nomLaboratoire;
        protected double salaire;

        public Personnel(int matricule, string nom, int anneeArivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tLaboratoire : " + this.nomLaboratoire + "\n\tSalaire : " + this.salaire;
        }
    }
}
