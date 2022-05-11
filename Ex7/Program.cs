using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se citesc doua numere de la tastatura. Scrieti un program
            // care va calcula cel mai mare divizor comun al numerelor.

            Console.WriteLine("Introduceti primul numar");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine(CMMDC(numar1, numar2));

            static string CMMDC(int numar1, int numar2)
            {
                int celMaiMAre = numar1 > numar2 ? numar1 : numar2;

                if (numar1 < 1 || numar2 < 1) 
                    return "Ambele numere trebuie sa fie mai mari decat 0";

                for (int i = celMaiMAre - 1; i > 1; i--)
                {
                    if (numar1 % i == 0 && numar2 % i == 0) 
                        return $"Cel mai mare divizor cumun al numerelor {numar1} si {numar2} este  {i}";
                }

                if (numar1 == numar2)
                    return $"Cel mai mare divizor comun este {numar1}";

                return "Cel mai mare divizor comun este 1";
            }
        }
    }
}
