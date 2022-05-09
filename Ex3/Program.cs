using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care determina daca un numar n citit
            // de la tastatura este un patrat perfect.

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            Console.WriteLine(PatratPerfect(numar));
        }

        static string PatratPerfect(int numar)
        {
            if (numar < 1)
            {
                return "Numarul nu poate fi negativ sau mai mic decat 1";
            }

            double valoare = Math.Sqrt(numar);

            if(valoare == (int)valoare)
            {
                return $"Numarul {numar} este patrat perfect";
            }
            else
            {
                return $"Numarul {numar} nu este patrat perfect";
            }
        }
    }
}
