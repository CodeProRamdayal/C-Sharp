using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{

    public class CreditCard : IPaymentInterface
    {
        private decimal TotalAmount { get; set; }
        public void AddBalance(decimal newAmount)
        {
            TotalAmount += newAmount;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal paymant of {amount}");
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }
    }



    public class PaypalProcessor : IPaymentInterface
    {
        private decimal TotalAmount { get; set; }
        public void AddBalance(decimal newAmount)
        {
            TotalAmount += newAmount;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal paymant of {amount}");
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }
    }


    internal class PaymentService
    {
        private readonly IPaymentInterface _processor;
        public PaymentService(IPaymentInterface processor)
        {
            _processor = processor;

        }

        public void ProcessOrderPaymant(decimal amount)
        {
            _processor.AddBalance(amount);
            _processor.ProcessPayment(amount);
        }
    }
}
