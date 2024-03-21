using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TP3Commercial
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        public Categories ca;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }

        public Commercial(string Nom, string Prenom, int AnneeNaissance, Categories Ca)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.anneeNaissance = AnneeNaissance;
            this.ca = Ca;
        }

        public double CalculAge()
        {
            return DateTime.Now.Year - this.anneeNaissance;
        }

        public override string ToString() => " \n -----*-----------------------------*----- \n Nom : " + this.nom + "\n Prénom : " + this.prenom + "\n Année de naissance : " + this.anneeNaissance + "\n Ce commercial a " + CalculAge() + "ans" + "\n Catégorie : " + this.ca;

        public void compare(Commercial c)
        {
            if (c.Nom == this.Nom)

              Console.WriteLine (" \n -----*-----------------------------*-----\n Les deux commerciaux ont le même nom de famille"); 

            c.Nom = nom;
        }
    }


}