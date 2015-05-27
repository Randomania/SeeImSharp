using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Week01Day01PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random songChoice = new Random();

            int song = songChoice.Next(3);

            switch(song){
                case 0:
                SoundPlayer EdisonMary = new SoundPlayer("http://www.wavsource.com/snds_2015-05-24_3842437052126496/people/famous/edison.wav");
                EdisonMary.PlaySync();
                    break;
                case 1:
                SoundPlayer EastWood = new SoundPlayer("http://www.wavsource.com/snds_2015-05-24_3842437052126496/people/famous/eastwood_lawyers.wav");
                EastWood.PlaySync();
                    break;
                case 2:
                SoundPlayer grahamNation = new SoundPlayer("http://www.wavsource.com/snds_2015-05-24_3842437052126496/people/famous/graham_any_nation.wav");
                grahamNation.PlaySync();
                    break;
            }
            

            
            

        }
    }
}
