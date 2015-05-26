using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,thisMany;
            Console.WriteLine("Please input two numbers to add.");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            thisMany = num1 + num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + thisMany);

            Console.ReadLine();
        }
    }
}
