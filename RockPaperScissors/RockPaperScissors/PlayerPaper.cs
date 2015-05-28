using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayerPaper
    {

     public static int Roll()
     {
         Random util = new Random();
         int choice = util.Next(3);
         return choice;
     }   

    }
}
