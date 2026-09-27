using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{
    internal interface IPaymentInterface
    {
        public void AddBalance(decimal newAmount);
        public void ProcessPayment(decimal amount);
    }
}
