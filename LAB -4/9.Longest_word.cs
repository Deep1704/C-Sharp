using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "My Name is Deep, Currently I am studying CSE(IT).";
            String max = "";
            String[] sperator = { " " };

            String[] strlist = str.Split(sperator, StringSplitOptions.None);

            foreach (String s in strlist)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }

            Console.WriteLine("Longest word is: " + max);

        }
    }
}
