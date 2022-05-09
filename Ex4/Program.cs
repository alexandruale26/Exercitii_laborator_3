using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se citesc numere de la tastatură până la apariția lui zero.
            // Să se determine suma lor.
            
            int suma = 0, contor = 0;

            while (true)
            {
                Console.WriteLine("Introduceti numarul");
                int numar = int.Parse(Console.ReadLine());

                if (numar == 0)
                {
                    Console.WriteLine("Ati introdus cifra 0");
                    break;
                }
                else
                {
                    suma += numar;
                    contor++;
                    Console.WriteLine($"Suma celor {contor} numere este {suma}");
                }
            }
        }
    }
}
