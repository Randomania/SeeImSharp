using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocaPapelTijera
{
    class Rock
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
                    return "Rock Beats Scissor";
                    break;
                case 3:
                    return "Paper Beats Rock";
                    break;
                default:
                    return "No Idea";

            };
        }
    }
}
