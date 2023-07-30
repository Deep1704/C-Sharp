/* Create a class Furniture with material ,price as data members. Create 
another class Table with Height , surface_area as data members. Write a
program to implement single inheritance.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table();
            t1.printTable();
            t1.printFurniture();
            Console.ReadLine();
        }

        class Furniture
        {
            String material;
            double price;

            public void printFurniture()
            {
                Console.WriteLine("Furniture Class");
            }
        }

        class Table : Furniture
        {
            double height;
            String surfacearea;

            public void printTable()
            {
                Console.WriteLine("Table Class");    
            }
        }
    }
}
