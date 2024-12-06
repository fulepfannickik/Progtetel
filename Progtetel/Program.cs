using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 7, 4, 8, -5, 6};

            //Párosak kiválogatása - 1

            int[] parosak = new int[100];

            int i;
            int db = 0;

            for (i = 0; i < x.Length; i++)
            {

                if (x[i] % 2 == 0)
                {
                    parosak[db] = x[i];
                    db++;
                }
            }

            for (i = 0; i < db; i++)
            {
                Console.Write(parosak[i] + " ");
            }
            Console.WriteLine();



            //Maximum kiválasztás - 2
            int maxi = 0;
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] > x[maxi])
                {
                    maxi = i;
                }
            }
            Console.WriteLine($"{maxi + 1}, {x[maxi]}");
            Console.ReadKey();
        }
    }
}
