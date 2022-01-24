using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             bool flag = true;
             while (flag)
             {
                 Console.WriteLine("1.FlipCoin."
                     +"\n 2.LeapYear."
                 +"\n 3.ReplaceString"
                 +"\n 4.Exit");
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
                     case 4:    flag = false;
                         break;
                     default: Console.WriteLine("Choose Correct option");
                         break;
                 }



             }   
        }
    }
}
