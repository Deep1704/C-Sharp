/*Create a Stack which takes integer values and perform following 
operations:
a. Push() - To Add new item in stack
b. Pop() - To Remove item from the stack
c. Peek() – To Return the top item from the stack.
d. Contains() - To Checks whether an item exists in the stack or not.
e. Clear() - To clear items from stack*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Stack<int> st = new Stack<int>();

            //To Add

            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);
            st.Push(7);
            Console.WriteLine("After Add: ");
            p1.Display(st);
            Console.WriteLine("_______________________");

            //To Remove

            st.Pop();
            Console.WriteLine("\nAfter Remove: ");
            p1.Display(st);
            Console.WriteLine("_______________________");

            //Peek

            Console.WriteLine("\nTop Element: " + st.Peek());
            Console.WriteLine("_______________________");

            //Contains

            Console.WriteLine("\nElement 3 Available.? : "+st.Contains(3));
            Console.WriteLine("_______________________");

            //To clear

            st.Clear();
            Console.WriteLine("\nAfter Clear: ");
            p1.Display(st);





        }

        public void Display(Stack<int> st)
        {
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
        }
    }
}
