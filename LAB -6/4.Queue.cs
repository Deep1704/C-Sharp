/* Create a Queue which takes integer values and perform following 
operations: 
a. Enqueue() - Adds an item into the queue.
b. Dequeue() - Returns an item from the beginning of the queue and 
 removes it from the queue.
c. Peek() - Returns an first item from the queue without removing it.
d. Contains() - Checks whether an item is in the queue or not
e. Clear() - Removes all the items from the queue*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Queue<int> q = new Queue<int>();    

            //To Add
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);   
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            Console.WriteLine("After Add: ");
            p1.Display(q);
            Console.WriteLine("______________________");

            //To Remove

            q.Dequeue();
            Console.WriteLine("\nAfter Remove: ");
            p1.Display(q);
            Console.WriteLine("______________________");

            //Peek

            Console.WriteLine("\nTop Element: " + q.Peek());
            Console.WriteLine("______________________");

            //Contains

            Console.WriteLine("\nNumber 5 Available:  "+q.Contains(5));
            Console.WriteLine("______________________");

            //Clear

            q.Clear();
            Console.WriteLine("\nAfter clear: ");
            p1.Display(q);


        }
        public void Display(Queue<int> q)
        {
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
