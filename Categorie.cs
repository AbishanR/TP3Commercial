using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Commercial
{
    internal class Categories
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categories(string codeCategorie, string libCategorie)
        {
            this.CodeCategorie = codeCategorie;
            this.LibCategorie = libCategorie;

        }

        public override string ToString() => "\n Voici le code de la catégorie : " + this.codeCategorie + "\n Voici le libellé de la catégorie : " + this.libCategorie;

    }
}
