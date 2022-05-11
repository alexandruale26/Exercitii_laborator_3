using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care citind de la tastatura lungimea 
               si latimea unui dreptunghi, va afisa diagonala acestuia.
               Calculul diagonalei va fi extras intr-o functie.
            */

            Console.WriteLine("Introduceti lungimea");
            double lungime = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            double latime = double.Parse(Console.ReadLine());


            Console.WriteLine("Diagonala este " + DiagonalaDreptunghiului(lungime, latime));

            static double DiagonalaDreptunghiului(double lungime, double latime)
            {
                if (lungime < 1 || latime < 1)
                {
                    Console.WriteLine("Lungimea si latimea trebuie sa fie mai mari decat 0");
                    return 0;
                }

                return Math.Sqrt(Math.Pow(lungime, 2) + Math.Pow(latime, 2));
            }
        }
    }
}
