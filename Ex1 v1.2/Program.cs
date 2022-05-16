using System;

namespace Ex1_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care sa calculeze maximul a trei numere citite
            // de la  tastatura. Ex: se citeste 3,15,4 Vom afisa 15.

            int[] numere = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduceti numarul");
                numere[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numere);

            Console.WriteLine("Maximul este --> " + numere[2]);
            

        }
    }
}
