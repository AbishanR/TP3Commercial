namespace TPCommercial
{

    class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }

        public Commercial(string Nom, string Prenom, int AnneeNaissance)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.anneeNaissance = AnneeNaissance;
        }

        public double CalculAge()
        {
            return 2024 - this.anneeNaissance;
        }
    }


}   