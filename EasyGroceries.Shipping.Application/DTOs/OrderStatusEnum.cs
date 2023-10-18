using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.DTOs
{
    public enum OrderStatusEnum
    {
        Pending,
        Approved,
        Processed,
        Completed,
        Canceled
    }
}
