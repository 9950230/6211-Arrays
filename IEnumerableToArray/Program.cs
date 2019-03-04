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
            randomDoubles = generateOneThousandDoubles();
            // TODO: Change to copy()
            randomDoublesOriginal = randomDoubles;

            var numbersGreaterThanTwo = from number
                                        in randomDoubles
                                        where number > 2
                                        select number;

            //Console.WriteLine(numbersGreaterThanTwo.GetType());

            randomDoubles = numbersGreaterThanTwo.ToArray();

            double[] randomDoublesAscending = new double[1000];
            randomDoublesAscending = randomDoubles;
            Array.Sort(randomDoublesAscending);
            Array.Reverse(randomDoublesAscending);

            double[] randomDoublesDescending = new double[1000];
            randomDoublesDescending = randomDoubles;
            Array.Sort(randomDoublesDescending);

            Console.WriteLine("***** Ascending Random Doubles");

            WriteTenDoublesPerLine(randomDoublesAscending);

            Console.WriteLine("\n\n\n***** Descending Random Doubles");

            WriteTenDoublesPerLine(randomDoublesDescending);

            Console.ReadKey();
        }


        static void WriteTenDoublesPerLine(double[] doubleNumbers)
        {
            int x = 1;
            foreach (double doubleNumber in doubleNumbers)
            {
                Console.Write("{0} ", doubleNumber);

                if (x == 10)
                {
                    x = 0;
                    Console.Write("\n");
                }

                x++;
            }
        }


        static double[] generateOneThousandDoubles()
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
