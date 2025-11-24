using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.OOPS
{
    public class PaymentService
    {
        public Dictionary<string, PaymentMethod> paymentRecords;
        public PaymentService()
        {
            paymentRecords = new Dictionary<string, PaymentMethod>();
        }

        public void AddPaymentMethod(string userId, PaymentMethod paymentMethod)
        {
            paymentRecords[userId] = paymentMethod;
        }
        public void MakePayment(string userId)
        {
            if (paymentRecords.ContainsKey(userId))
            {
                paymentRecords[userId].Pay(); //RunTime  Polymorphism
            }
            else
            {
                Console.WriteLine("No payment method found for the user.");
            }
        }
    }
}
