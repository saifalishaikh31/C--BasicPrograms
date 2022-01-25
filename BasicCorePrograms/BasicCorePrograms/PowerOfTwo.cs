using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public void PwrOfTwo()
        {
            int power, result = 1;
            string N;
            Console.WriteLine("Enter the power of 2 : ");
            N = Console.ReadLine();
            power = Convert.ToInt32(N);
            if (power < 31 && power >= 0)
            {
                while (power != 0)
                {
                    result = result * 2;
                    --power;
                }
                Console.WriteLine("Answer = " + result);
            }
            else
            {
                Console.WriteLine("Wrong input will over flow int");
            }
        }
    }
}
