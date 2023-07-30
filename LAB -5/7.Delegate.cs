/*Write a program to create a delegate called TrafficDel and a class called 
TrafficSignal with the following delegate methods.
Public static void Yellow()
{
Console.WriteLine(“Yellow Light Signal To Get Ready”);
}
Public static void Green()
{
Console.WriteLine(“Green Light Signal To Go”);
}
Public static void Red()
{
Console.WriteLine(“Red Light Signal To Stop”);
}
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        public static void Main(string[] args)
        {

            TrafficSignal ts = new TrafficSignal();
            ts.IdentifySignal();
            ts.Display();
            Console.ReadLine();
        }
    }

    public delegate void TrafficDel();

    class TrafficSignal
    {
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

        TrafficDel[] t1 = new TrafficDel[3];

       public void IdentifySignal()
        {
            t1[0] = new TrafficDel(Yellow);
            t1[1] = new TrafficDel(Green);
            t1[2] = new TrafficDel(Red);
        }

        public void Display()
        {
            t1[0]();
            t1[1]();
            t1[2]();
        }
    }

}
