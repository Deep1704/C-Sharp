/*Create an ArrayList for StudentName and perform following operations:
a. Add() - To Add new student in list
b. Remove() - To Remove Student with specified index
c. RemoveRange() - To Remove student with specified range.
d. Clear() - To clear all the student from the list*/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            //To Add
            arraylist.Add("Rushi");
            arraylist.Add("Kevin");
            arraylist.Add("Akashay");
            arraylist.Add("Krish");
            arraylist.Add("Deep");
            arraylist.Add("Krutik");

            Console.WriteLine("After add:  ");
            printarraylist(arraylist);
            Console.WriteLine("______________________________________");

            //To Remove   


            arraylist.RemoveAt(0);
            Console.WriteLine("\nAfter Remove:  ");
            printarraylist(arraylist);
            Console.WriteLine("______________________________________");

            //To RemoveRange

            arraylist.RemoveRange(0, 2);
            Console.WriteLine("\nAfter RemoveRange:  ");
            printarraylist(arraylist);
            Console.WriteLine("______________________________________");

            Console.WriteLine(arraylist.Contains("2"));

            //To Clear

            arraylist.Clear();
            Console.WriteLine("\nAfter Clear:  ");
            printarraylist(arraylist);

        }

        static void printarraylist(ArrayList arraylist)
        {

            foreach (var i in arraylist)
            {

                Console.WriteLine(i);
            }
        }
    }
}
