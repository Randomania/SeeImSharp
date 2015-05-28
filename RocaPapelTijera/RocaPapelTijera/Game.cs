using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocaPapelTijera
{
    public class Game
    {
        public static string Fight()
        {
            //Random rnd = new Random();
            //int choice = rnd.Next(1,4);
            Console.WriteLine("1 Paper 2 Rock 3 Scissor");
            

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                        return Paper.Roll();
                        break;
                case 2:
                        return Rock.Roll();
                        break;
                case 3:
                        return Scissor.Roll();
                        break;
                default:
                        return "Wrong, Sad";
                        break;
            };

        }


    }
}
