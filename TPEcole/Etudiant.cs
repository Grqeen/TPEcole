namespace Classes.ClassesEcole
{
    internal class Etudiant : Contact
    {

        protected string section;

        public Etudiant(int matricule, string nom, int anneeArivee, string section) : base(matricule, nom, anneeArivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.section = section;
        }

        public string Section { get => section; set => section = value; }

        public override string ToString()
        {
            return base.ToString() + "\n\tSection : " + this.section;
        }
    }
}
