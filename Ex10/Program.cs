using System;

namespace Ex10_v1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi,
                aceasta s-a apucat să prepare clătite. Arpsod mănâncă toate clătitele începând 
                de la a N-a clătită preparată, până la a M-a clătită preparată inclusiv N ș i M).
                Pentru că el vrea să mănânce clătite cu diferite umpluturi și-a făcut următoarea
                regulă. 
                    Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată. 
                Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem. Dacă suma
                divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu 
                înghetată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
                    Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de 
                ordine par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.

                    Cerința:
                Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod 
                în total și numărul de clătite din fiecare tip.

                    Indicii:
                1. iteratorul unui for nu incepe neaparat de la 1
                2. folositi functii: extrageti operatiile matematice complicate asupra intregilor in funciti.
             */

            Console.WriteLine("Introduceti pe N");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti pe M");
            int m = int.Parse(Console.ReadLine());

            int[] index = NumarDeOrdineClatite(n, m);
            int ciocolata = 0, gem = 0, inghetata = 0, zahar = 0, simple = 0, total = 0;


            if (n < 1 || m < 1)
            {
                Console.WriteLine("Numerele trebuie sa fie mai mari decat 0");
                return;
            }
            else if (m < n || m == n)
            {
                Console.WriteLine("M trebuie sa fie mai mare decat N");
                return;
            }


            Clatite();


            Console.WriteLine("Ciocolata " + ciocolata);
            Console.WriteLine("Gem " + gem);
            Console.WriteLine("Inghetata " + inghetata);
            Console.WriteLine("Zahar " + zahar);
            Console.WriteLine("Simple " + simple);
            Console.WriteLine("Total clatite  --> " + total);
            


            static int[] NumarDeOrdineClatite(int n, int m)
            {
                int[] index = new int[m + 1 - n];

                for (int i = 1; m >= n; i++)
                {
                    index[i-1] = i;
                    m--;
                }
                return index;
            }

            static bool Prim(int n)
            {   
                // numarul 1 va fi adaugat intotdeauna la gogoasa cu ciocolata deoarece este numar prim
                // nu putem avea prima gogoasa cu mai multe umpluturi (1 este numar prim dar si patrat perfect dar si cub perfect).
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }

            static bool PatratPerfect(int n)
            {
                double valoare = Math.Sqrt(n);

                if (n != 1 && valoare == (int)valoare)
                    return true;
                else 
                    return false;
            }

            static bool CubPerfect(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (i * i * i == n)
                        return true;
                }
                return false;
            }

            static bool SumaDivizorilor(int n)
            {
                int sumaDivizori = 0;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        sumaDivizori += i;
                }

                if (sumaDivizori == n)
                    return true;
                else
                    return false;
            }


            void Clatite()
            {
                for (int i = 0; i < index.Length; i++)
                {
                    if (Prim(index[i]))
                        ciocolata++;
                    else if (PatratPerfect(index[i]) || CubPerfect(index[i]))
                        gem++;
                    else if (SumaDivizorilor(index[i]))
                        inghetata++;
                    else if (index[i] % 2 == 0)
                        zahar++;
                    else
                        simple++;
                }

                total += ciocolata + gem + inghetata + zahar + simple;
            }
        }
    }
}
