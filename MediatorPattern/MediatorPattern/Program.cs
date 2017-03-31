using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var abcCorner = new AbcFoodCorner(mediator);
            var xyzCorner = new XyzFoodCorner(mediator);
            mediator.AbcCorner = abcCorner;
            mediator.XyzCorner = xyzCorner;

            abcCorner.Send("I need Pitza");
            xyzCorner.Send("I need Burger");
        }
    }
}