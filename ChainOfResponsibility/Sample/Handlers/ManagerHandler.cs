using System;
using System.Collections.Generic;
using System.Text;
using Sample.Request;

namespace Sample.Handlers
{
    public class ManagerHandler : AbstractHandler
    {
        public override void Handle(PurchaseOrder order)
        {
            if (order.OrderAmount <= 2000)
            {
                Console.WriteLine($"Your order {order.Id} is handled by {this.GetType().Name}");
            }
            else
            {
                if (this.Handler != null)
                    this.Handler.Handle(order);
            }
        }
    }
}
