/*Create a List for StudentName and perform following operations:
a. Add() - To Add new student in list
b. Remove() - To Remove Student with specified index
c. RemoveRange() - To Remove student with specified range.
d. Clear() - To clear all the student from the list*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L6P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();
            List<string> list = new List<string>();

            //To Add

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            Console.WriteLine("After Add:");
            p1.Display(list);
            Console.WriteLine("_______________________________");

            //To Remove

            list.Remove("A");
            Console.WriteLine("\nAfter Remove:");
            p1.Display(list);
            Console.WriteLine("_______________________________");


            //To RemoveRange

            list.RemoveRange(1, 2);
            Console.WriteLine("\nAfter RemoveRange:");
            p1.Display(list);
            Console.WriteLine("_______________________________");

            //To Clear

            list.Clear();
            Console.WriteLine("\nAfter Clear: ");
            p1.Display(list);





        }
        public void Display(List<string> list)
        {
            for (int i = 0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }

            }
    }
}
