using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public void FindHarmonicNumber()
        {
            int i, N;
            double ans = 0.0;

            Console.WriteLine("Enter Nth number to find Harmonic Number");
            N = Convert.ToInt32(Console.ReadLine());
            if (N != 0)
            {
                for (i = 1; i <= N; i++)
                {

                    ans += 1 / (float)i;
                }
                Console.Write("\nSum of Series upto " + N + "terms : " + ans + "\n");
            }
            else
            { Console.WriteLine("Do not Enter 0 !!!"); }
        }
    }
}
