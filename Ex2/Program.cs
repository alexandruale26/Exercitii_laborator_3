using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va citi de la tastatura un numar intreg pozitiv
            // si va afisa valoarea acestuia in baza 2. Ex: se citeste 42, vom afisa 101010.

            Console.WriteLine("Introduceti numarul");
            double intrare = double.Parse(Console.ReadLine());

            int numar = (int)intrare;
            string mesaj = "";

            if (numar < 1)
            {
                Console.WriteLine("Numarul nu poate fi mai mic decat 1");
                return;
            }

            while (numar != 0)
            {
                int cifra = numar % 2;
                numar /= 2;
                mesaj += cifra;
            }
            
            char[] aux = mesaj.ToCharArray();
            Array.Reverse(aux);

            foreach(char c in aux)
            {
                Console.Write(c);
            }

            

            

        }
    }
}
