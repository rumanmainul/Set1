using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            float number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            float number2 = Convert.ToInt32(Console.ReadLine());

            float AddResult = number1 + number2;
            float DivResult = number1 / number2;
            float subResult = number1 - number2;
            float MultResult = number1*number2;

            Console.WriteLine("Addition result:"+AddResult);
            Console.WriteLine("Division result:" + DivResult);
            Console.WriteLine("Substraction result:" + subResult);
            Console.WriteLine("Multification result:" + MultResult);
            Console.ReadKey();
        }
    }
}
