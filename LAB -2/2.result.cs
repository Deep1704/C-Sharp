/*The marks obtained by a student in 5 different subjects are input through 
the keyboard. The student gets a grade as per the following rules:
a. Percentage above or equals to 60-first grade
b. Percentage between 50 to 59-second grade
c. Percentage between 40 and 49-Third grade
d. Percentage less than 40-poor Grad*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Subject Mark : ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Subject Mark : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Third Subject Mark : ");
            int s3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fourth Subject Mark : ");
            int s4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fifth Subject Mark : ");
            int s5 = Convert.ToInt32(Console.ReadLine());

            int percentage = (s1 + s2 + s3 + s4 + s5) / 5;

            if (percentage >= 60)
            {
                Console.WriteLine("First Division");
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Console.WriteLine("Second Division");
            }
            else if (percentage >= 40 && percentage <= 49)
            {
                Console.WriteLine("Third Division");
            }
            else if (percentage <= 40)
            {
                Console.WriteLine("Fail");
            }

            Console.ReadLine();
        }
    }
}
