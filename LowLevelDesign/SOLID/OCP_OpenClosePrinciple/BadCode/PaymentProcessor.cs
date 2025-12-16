using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.OCP_OpenClosePrinciple.BadCode
{
    public class PaymentProcessor
    {
        public void processPayment(String paymentMethod, double amount)
        {
            if (paymentMethod.Equals("CreditCard"))
            {
                //business logic
                Console.WriteLine("Making payment via Credit Card :" + amount);
            }
            else if (paymentMethod.Equals("Debit Card"))
            {
                //business logic
                Console.WriteLine("Making payment via Debit Card :" + amount);
            }
            else if (paymentMethod.Equals("Paypal"))
            {
                //business logic
                Console.WriteLine("Making payment via PayPal :" + amount);
            }
            else
            {
                throw new Exception("Unsupported payment method " + paymentMethod);
            }
        }
    }
}
