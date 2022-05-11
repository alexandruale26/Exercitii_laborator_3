using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrie un program care afiseaza numerele de la 1 la N. Daca numarul 
               este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 5 sa se 
               afiseze Buzz, daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze 
               FizzBuzz, in restul cazurilor sa se afiseze numarul.
            */

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            if (numar < 1)
                Console.WriteLine("Numarul trebuie sa fie mai mare decat 0");

            for (int i = 1; i <= numar; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
