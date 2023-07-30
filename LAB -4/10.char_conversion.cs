/*Write a program to change a case of entered character.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character : ");
            char c = Console.ReadLine().ToCharArray()[0];
            char ans;

            if(char.IsUpper(c)) { 

                ans = char.ToLower(c);
            }
            else
            {
                ans = char.ToUpper(c);
            }

            Console.WriteLine("Changed case of character : " + ans);

            Console.ReadLine();
        }
    }
}
