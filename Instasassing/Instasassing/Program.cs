using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instasassing
{
    class Program
    {
        static void Main(string[] args)
        {

            string statement = "There are many tortillas here.";

            int numberOfWords = WordCount.HowMany(statement);

            Console.WriteLine(numberOfWords);
            Debug.Assert(numberOfWords == 5, "Oh Noes!");
            Console.ReadKey();
        }
    }
}
