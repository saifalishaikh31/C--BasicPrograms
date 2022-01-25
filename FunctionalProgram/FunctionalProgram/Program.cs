using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgram
{
    class Program
    {
        static void Main(string[] args)
        {

             bool flag = true;
             while (flag)
             {
                 Console.WriteLine(" 1.Two Dimensional Array."
                     + "\n 2.Exit");
                 int option = Convert.ToInt32(Console.ReadLine());
                 switch (option)
                 {
                     case 1: TwoDArray twodimarray = new TwoDArray();
                         twodimarray.TwoDimArray();
                         break;
                     case 2: flag = false;
                         break;
                     default: Console.WriteLine("Choose Correct option");
                         break;
                 }
             }
            Console.ReadLine();
        }
    }
}
