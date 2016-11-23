using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public String FirstName { get; set; }
        public String LastName  { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }
        public Vendor()
        {
            Commission = 0.5;
        }

        public String Display
        {
            get
            {
                return String.Format("{0} {1} - ${2}", FirstName, LastName, PaymentDue);
            }
        }
    }
}
