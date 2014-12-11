using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedForLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lower limit:");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter upper limit:");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Userdefined Forloop:");
            for (int i = lowerNumber; i <= upperNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
