using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocaPapelTijera
{
    public class Paper
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
                    return "Paper Beats Rock";
                    break;
                case 3:
                    return "Scissor Beats Paper";
                    break;
                default:
                    return "No Idea";

            };
        }
    }
}
