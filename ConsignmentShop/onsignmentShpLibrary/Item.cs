using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool paymentDistributed { get; set; }
        public Vendor Owner { get; set; }

        public String Display
        {
            get
            {
                return String.Format("{0} - ${1}", Title, Price);
            }
        }
    }
}
