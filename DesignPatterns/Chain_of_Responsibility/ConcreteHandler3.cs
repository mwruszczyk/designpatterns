using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Chain_of_Responsibility
{
    public class ConcreteHandler3 : Handler
    {

        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handles request {1}",
                    this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);

            }
        }
    }
}
