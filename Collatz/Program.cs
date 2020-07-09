using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine().Split(' ')[0]);

            string[] regels = new string[n];
            for (int i = 0; i < n; i++)
            {
                regels[i] = Console.ReadLine();
            }

            List<int> collatzLengths = new List<int>();

            foreach (string regel in regels)
            {
                long getal = long.Parse(regel.Split(' ')[0]);

                int collatzLengte = 0;

                while (getal > 1)
                {
                    if (getal % 2 == 0)
                    {
                        getal /= 2;
                        collatzLengte++;
                    }
                    else
                    {
                        getal *= 3;
                        getal++;
                        collatzLengte++;
                    }
                }
                collatzLengths.Add(collatzLengte);
            }

            foreach (int collatzlengte in collatzLengths)
            {
                Console.WriteLine(collatzlengte);
            }
        }
    }
}
