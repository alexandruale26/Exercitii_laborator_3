using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va determina daca un numar n este sau nu
            // numar prim, n fiind citit de la tastatura. Daca este numar prim, va afisa “prim”.
            // In caz contrar va afisa numarul cu care este divizibil.

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());
            int[] divizor = {2,3,5,7};

            Console.WriteLine(Prim(numar, divizor));

            static string Prim(int numar, int[] divizor)
            {
                if (numar < 2) 
                    return "Numarul introdus nu poate fi mai mic decat 2";

                if (numar == 2) 
                    return "Numarul 2 este prim";

                for (int i = 0; i < divizor.Length; i++)
                {
                    if (numar % divizor[i] == 0) 
                        return $"Numarul {numar} este divizibil cu {divizor[i]}";
                }

                return $"Numarul {numar} este prim";
            }
        }
    }
}
