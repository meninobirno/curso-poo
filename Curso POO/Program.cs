using Curso_POO.Entities;
using Curso_POO.Entities.Enums;
using System;

namespace Curso_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 3,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        }
    }
}
