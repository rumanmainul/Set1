using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstNumber:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Big number is"+firstNumber);
                Console.WriteLine("Small number is"+secondNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Big number is" + secondNumber);
                Console.WriteLine("Small number is" + firstNumber);
            }
            else
            {
                Console.WriteLine("Number is equal");
            }
            Console.ReadKey();
        }
    }
}
