using System.Security.Cryptography;
using TP3Commercial;

class program
{
    static void Main(string[] args)
    {
        Categories ca1 = new Categories
            ("1", "Salarié");

        Categories ca2 = new Categories
            ("2", "Indépendant");

        Commercial c1 = new Commercial 
            ("LaMenace", "Yass",2005, ca1 );

        Commercial c2 = new Commercial
            ("LaMenace", "Akira", 1994, ca2 );

        Commercial c3 = new Commercial
            ("Patrick", "LeMaire", 1957, ca2 );

        Console.WriteLine ("voici les infos du commercial : " + c1 + c2 + c3);
        c1.compare(c2);

    }

    
}