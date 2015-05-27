using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("This is a calculator");
            int num1, num2, total = 0;
            char symbol;

            num1 = Convert.ToInt32(Console.ReadLine());
            symbol = Convert.ToChar(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (File.Exists("Salami.txt"))
            {
                Console.WriteLine("Oh hey its here, great");
            }

            /*switch (symbol)
            {
                case '+':
                    {
                        total = num1 + num2;
                        Console.WriteLine("Okay");
                        break;
                    }
                case '-':
                    {
                        total = num1 - num2;
                        Console.WriteLine("Okay");
                        break;
                    }
                case '/':
                    {
                        total = num1 / num2;
                        Console.WriteLine("Okay");
                        break;
                    }

            }

            Console.WriteLine("The answer is " + total);


            
            Console.WriteLine( DateTime.Now.ToString("yy-mm-dd"));*/

            int day, month, year;

            Console.WriteLine("Enter the Month:  ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Day:  ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year:  ");
            year = Convert.ToInt32(Console.ReadLine());

            DateTime masterTiming = new DateTime(year, month, day);

            Console.WriteLine(masterTiming.ToString("D"));

            Console.ReadKey();

            string name = "Abdiel Numero Gonzalez Guzmanes", name2;

            string[] seperated = name.Split(' ');

            Array.Reverse(seperated);

            name2 = String.Join(" ", seperated);

            Console.WriteLine(name2);

            Console.ReadKey();

            Random sai = new Random();

            int chooser;

            chooser = sai.Next(3);

            Console.WriteLine(chooser);

            switch(chooser){
                case 0:
                    Console.WriteLine("No, I don't want to");
                    break;
                case 1:
                    Console.WriteLine("Hell, if there was even");
                    break;
                case 2:
                    Console.WriteLine("I could tell from the beginning");
                    break;
            }

            Console.ReadKey();

            }
    }
}
