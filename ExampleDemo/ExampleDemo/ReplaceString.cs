using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleDemo
{
    class ReplaceString
    {
   
        public void ReplaceStr()
        {
            Console.WriteLine("Enter UserName : ");
            string template = "Hello <<UserName>>, How are you?";
            string UName = Console.ReadLine();

            if (UName.Length < 3)
            {
                Console.WriteLine("UserName must have atleast upto 3 characters");
            }
            else
            {
                Console.WriteLine("Old String : " + template);
                Console.WriteLine("New String : " + template.Replace("<<UserName>>",UName));
             }
        }
    }
}
