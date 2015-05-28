 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public int PlayerPaper { get; set; }
        public int PlayerScissors { get; set; }
        public int PlayerRock { get; set; }

        public bool Fight()
        {
            PlayerPaper P = new PlayerPaper();
            PlayerRock R = new PlayerRock();
            PlayerScissors S = new PlayerScissors();

            Random util = new Random();
            int choice = util.Next(3);

            switch (choice)
            {
                case 0:
                    string winner = P.Roll();
            };

        }


    }
}
