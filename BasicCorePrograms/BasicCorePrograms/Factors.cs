using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void FindFactors()
        {
            int num;

            Console.WriteLine("Enter no to find Prime Factors");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i <= num; i++)
            {
                bool flag = false;
                if (num % i == 0)
                {
                    flag = true;
                    for (int j = 2; j < i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                        }
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}
