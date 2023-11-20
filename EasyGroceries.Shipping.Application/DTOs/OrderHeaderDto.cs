using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.DTOs
{
    public class OrderHeaderDto
    {
        public int OrderHeaderId { get; set; }
        public int UserId { get; set; }
        public bool LoyaltyMembershipOpted { get; set; }
        public double OrderTotal { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }
        public CustomerDto CustomerInfo { get; set; }
        public IEnumerable<OrderDetailsDto> OrderDetails { get; set; }
    }
}
