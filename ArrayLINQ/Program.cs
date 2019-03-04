using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] randomDoubles = new double[1000];
            double[] randomDoublesOriginal = new double[1000];
            randomDoubles = GenerateOneThousandDoubles();
            randomDoubles.CopyTo(randomDoublesOriginal, 0);

            var numbersGreaterThanTwo = from number 
                                        in randomDoubles
                                        where number > 2
                                        select number;


            int x = 1;
            foreach (double randomDouble in numbersGreaterThanTwo)
            {
                Console.Write("{0} ", randomDouble);

                if (x == 10)
                {
                    x = 0;
                    Console.Write("\n");
                }

                x++;
            }

            Console.ReadKey();
        }

        static double[] GenerateOneThousandDoubles()
        {
            Random random = new Random();
            double[] randomDoubles = new double[1000];

            for (int i = 0; i < randomDoubles.Length; i++)
            {
                randomDoubles[i] = random.NextDouble() * 10;
            }

            return randomDoubles;
        }
    }
}
