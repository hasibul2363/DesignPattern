using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class Mediator : Imediator
    {
        public AbcFoodCorner AbcCorner { get; set; }
        public XyzFoodCorner XyzCorner { get; set; }
        public void Send(string message, FoodCornerBase foodCorner)
        {
            if (foodCorner.GetType() == typeof(AbcFoodCorner))
            {
                XyzCorner.Notify(message);
            }
            else
            {
                AbcCorner.Notify(message);
            }
        }
    }
}
