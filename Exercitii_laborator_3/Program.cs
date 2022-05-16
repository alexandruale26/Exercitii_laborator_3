using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care sa calculeze maximul a trei numere citite
            // de la  tastatura. Ex: se citeste 3,15,4 Vom afisa 15.

            Console.WriteLine("Introduceti numerele");
            int numar1 = int.Parse(Console.ReadLine());
            int numar2 = int.Parse(Console.ReadLine());
            int numar3 = int.Parse(Console.ReadLine());

            int max = 0;

            if (numar1 == numar2 && numar2 == numar3)
            {
                max = numar1;
            }
             else if (numar1 > numar2)
            {
                if (numar1 > numar3)
                {
                    max = numar1;
                }
                else
                {
                    max = numar3;
                }
            }
            else if (numar2 > numar3)
            {
                if (numar2 > numar1)
                {
                    max = numar2;
                }
                else
                {
                    max = numar3;
                }
            }
            else if (numar3 > numar1)
            {
                if (numar3 > numar2)
                {
                    max = numar3;
                }
                else
                {
                    max = numar2;
                }
            }

            Console.WriteLine("Maximul este --> " + max);
        }
    }
}
