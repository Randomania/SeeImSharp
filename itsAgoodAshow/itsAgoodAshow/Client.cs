using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsAgoodAshow
{
    public class Client
    {
        public Account Checking {get; set;}
        public Account Savings {get; set;}

        public ClientAccount()
        {
            this.Checking = new Account();
            this.Savings = new Account();
        }

    }
}
