namespace Classes.ClassesEcole
{
    internal class Secretaire : Personnel
    {

        public Secretaire(int matricule, string nom, int anneeArivee, string nomLaboratoire, double salaire): base(matricule, nom, anneeArivee, nomLaboratoire, salaire)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArivee = anneeArivee;
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }

    }
}
