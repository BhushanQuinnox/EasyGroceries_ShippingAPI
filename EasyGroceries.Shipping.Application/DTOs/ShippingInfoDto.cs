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
        public CustomerDto CustomerInfo { get; set; }
        public IEnumerable<ProductDto> ProductDetails { get; set; }
    }
}
