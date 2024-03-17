namespace Classes.ClassesEcole
{
    internal class EtudiantEchange : Etudiant
    {

        private string universiteOrigine;

        public EtudiantEchange(int matricule, string nom, int anneeArivee, string section, string universiteOrigine) : base(matricule, nom, anneeArivee, section)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.section = section;
            this.universiteOrigine = universiteOrigine;
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tUniversite d'origine : " + this.universiteOrigine;
        }
    }
}
