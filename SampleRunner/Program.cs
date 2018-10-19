using Sample.Request;
using Sample.Handlers;
using System;

namespace SampleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new PurchaseOrder {
                Id = 1, OrderAmount = 1600
            }            ;

            var order2 = new PurchaseOrder
            {
                Id = 2,
                OrderAmount = 600
            };

            var chef = new ChefHandler();
            var manager = new ManagerHandler();
            chef.SetHandler(manager);

            chef.Handle(order);
            chef.Handle(order2);

            Console.ReadLine();

        }


    }
}
