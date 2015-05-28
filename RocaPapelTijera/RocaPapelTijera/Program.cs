using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocaPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            Game firstPlay = new Game();

            Console.WriteLine(Game.Fight());

            Console.ReadKey();
        }
    }
}
