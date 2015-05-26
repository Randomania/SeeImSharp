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
            Console.WriteLine("This is a calculator");
            int num1, num2, total = 0;
            char symbol;

           // num1 = Convert.ToInt32(Console.ReadLine());
           // symbol = Convert.ToChar(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());

            if (File.Exists("Salami.txt"))
            {
                Console.WriteLine("Oh het its here, great");
            }
            MailMessage mail = new MailMessage("you@yourcompany.com", "user@hotmail.com");
            SmtpClient client = new SmtpClient();
            /*switch (symbol)
            {
                case '+':
                    {
                        total = num1 + num2;
                        Console.WriteLine("Okay");
                        break;
                    }

            }

            Console.WriteLine("The answer is " + total);*/
            Console.ReadKey();

        }
    }
}
