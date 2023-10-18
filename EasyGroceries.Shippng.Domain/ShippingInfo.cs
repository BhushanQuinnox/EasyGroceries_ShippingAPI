using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Domain
{
    internal class ShippingInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ApartmentName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}
