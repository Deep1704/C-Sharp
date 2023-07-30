/*. Write a program to Replace lower case characters to upper case and 
Vice-versa.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Darshan University";
            string result = "";
            foreach (char c in str)
            {
                if (Char.IsUpper(c))
                {
                    result += c.ToString().ToLower();
                }
                else
                {
                    result += c.ToString().ToUpper();
                }
            }
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
    }
}
