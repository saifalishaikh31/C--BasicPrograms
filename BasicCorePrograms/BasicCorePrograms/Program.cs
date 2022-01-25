using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.FlipCoin."
                               + "\n 2.LeapYear."
                               + "\n 3.ReplaceString"
                               + "\n 4.Power Of Two"
                               + "\n 5.Harmonic Number"
                               + "\n 6.Factors"
                + "\n 7.Exit \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipcoin = new FlipCoin();
                        flipcoin.HeadTailPercentage();
                        break;
                    case 2:
                        LeapYear leapyear = new LeapYear();
                        leapyear.CheckLeapYear();
                        break;
                    case 3:
                        ReplaceString replacestr = new ReplaceString();
                        replacestr.ReplaceStr();
                        break;
                    case 4:
                        PowerOfTwo poweroftwo = new PowerOfTwo();
                        poweroftwo.PwrOfTwo();
                        break;
                    case 5:
                        HarmonicNumber hrmnum = new HarmonicNumber();
                        hrmnum.FindHarmonicNumber();
                        break;
                    case 6:
                        Factors factors = new Factors();
                        factors.FindFactors();
                        break;
                    case 7: flag = false;
                        break;
                    default: Console.WriteLine("Choose Correct option");
                        break;
                }



            } 
        }
    }
}
