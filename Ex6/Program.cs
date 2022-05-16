using System;

namespace Ex6_v2
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

            Console.WriteLine(Prim(numar));

            static string Prim(int numar)
            {
                for (int i = 2; i * i <= numar; i++)
                {
                    if (numar % i == 0)
                        return $"Numarul {numar} este divizibil cu {i}";
                }
                return $"Numarul {numar} este prim";
            }
        }
    }
}
