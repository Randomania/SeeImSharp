using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocaPapelTijera
{
    class Scissor
    {
        public static string Roll()
        {
            Random rnd2 = new Random();
            int choice2 = rnd2.Next(1,4);
            switch (choice2)
            {
                case 1:
                    return "Tie";
                    break;
                case 2:
                    return "Scissor Beats Paper";
                    break;
                case 3:
                    return "Rock Beats Scissor";
                    break;
                default:
                    return "No Idea";

            };
        }
    }
}
