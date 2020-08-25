using Estudo_Enums.Entities;
using Estudo_Enums.Entities.Enum;
using System;

namespace Estudo_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            string txt = OrderStatus.Delivered.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");


            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
