using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Megabytes in your HardDrive?");
            Product Laptop = new Product();
            Laptop.hardDriveGB = 90;
            Console.WriteLine(Laptop.ShowMB());
            Console.ReadKey();
        }
    }
}
