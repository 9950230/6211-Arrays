using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] randomDoubles = new double[1000];
            
            for (int i = 0; i < randomDoubles.Length; i++)
            {
                randomDoubles[i] = random.NextDouble() * 10;
            }

            int x = 1;
            foreach (double randomDouble in randomDoubles)
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

    }
}
