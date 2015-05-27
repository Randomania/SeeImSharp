using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Product
    {
        public int hardDriveGB {get; set;}

        public int ShowMB()
        {
            return this.hardDriveGB * 1024;
        }
        public Product()
        { 
        
        }
    }
}
