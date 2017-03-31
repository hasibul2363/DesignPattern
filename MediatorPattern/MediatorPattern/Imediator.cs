using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface Imediator
    {
        void Send(string message, FoodCornerBase foodCorner);
    }
}
