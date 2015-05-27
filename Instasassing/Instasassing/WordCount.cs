using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instasassing
{
    public class WordCount
    {
        public static int HowMany(string array)
        {
            string[] master = array.Split(' ');
            int amount = master.Length;
            return amount;
        }
    }
}
