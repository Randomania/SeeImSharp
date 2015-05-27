using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PractizeTYwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer mike = new Customer();

            mike.FirstName = "Mike";
            mike.LastName = "Birbiglia";

            mike.BillingAddress = new Address();

            mike.BillingAddress.City = "Houston";
            mike.BillingAddress.State = "Texas";
            mike.BillingAddress.Street = "Heaney";
            mike.BillingAddress.ZIPcode = "77093";


            Customer rob = new Customer();

            mike.FirstName = "Rob";
            mike.LastName =  "Magico";

            mike.BillingAddress = new Address();

            mike.BillingAddress.City = "Deer Park";
            mike.BillingAddress.State = "Texas";
            mike.BillingAddress.Street = "Pinewood";
            mike.BillingAddress.ZIPcode = "77032";
        }
    }
}
