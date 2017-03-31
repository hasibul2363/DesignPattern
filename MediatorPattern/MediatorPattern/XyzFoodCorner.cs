using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class XyzFoodCorner : FoodCornerBase
    {
        public Imediator Mediator { get; set; }
        public XyzFoodCorner(Imediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Sending message {message}");
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"new order has placed : {message}");
        }
    }
}
