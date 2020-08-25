using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Enums.Entities.Enum
{
    enum OrderStatus : int 
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
