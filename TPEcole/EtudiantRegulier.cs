namespace Classes.ClassesEcole
{
    internal class EtudiantRegulier : Etudiant
    {

        private double noteMoyenne;

        public EtudiantRegulier(int matricule, string nom, int anneeArivee, string section, double noteMoyenne) : base(matricule, nom, anneeArivee, section)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.section = section;
            this.noteMoyenne = noteMoyenne;
        }

        public double NoteMoyenne { get => noteMoyenne; set => noteMoyenne = value; }

        public override string ToString()
        {
            return base.ToString() + "\n\tMoyenne : " + this.noteMoyenne;
        }


    }

}
