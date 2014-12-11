using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi "+userName+" Good day");
            Console.ReadKey();
        }
    }
}
