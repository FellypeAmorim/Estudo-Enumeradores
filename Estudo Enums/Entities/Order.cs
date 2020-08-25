using Estudo_Enums.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Enums.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment.ToLongDateString() + ", " + Status;
        }
    }
}
