using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se citesc numere de la tastatură până când se introduc două numere
            // consecutive egale. Să se determine suma tuturor numerelor citite.

            int suma = 0, contor = 0, val2 = int.MinValue;
            int aux, val1;

            while (true)
            {
                Console.WriteLine("Introduceti numarul");
                int numar = int.Parse(Console.ReadLine());

                val1 = numar;
                aux = val1;

                if (val1 == val2)
                {
                    Console.WriteLine("Ati introdus doua numere consecutive");
                    break;
                }
                else
                {
                    suma += numar;
                    contor++;
                    val2 = aux;
                    Console.WriteLine($"Suma celor {contor} numere este {suma}");
                }
            }
        }
    }
}
