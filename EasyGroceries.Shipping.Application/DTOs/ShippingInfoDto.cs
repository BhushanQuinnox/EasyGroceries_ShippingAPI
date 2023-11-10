using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.DTOs
{
    public class ShippingInfoDto
    {
        public int UserId { get; set; }
        public double OrderTotal { get; set; }
        public string Name { get; set; }
        public string ApartmentName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public IEnumerable<OrderDetailsDto> OrderDetails { get; set; }
    }
}
