using Sample.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Handlers
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler Handler { get; set; }
        public void SetHandler(AbstractHandler handler)
        {
            Handler = handler;
        }

        public abstract void Handle(PurchaseOrder order);
    }
}
