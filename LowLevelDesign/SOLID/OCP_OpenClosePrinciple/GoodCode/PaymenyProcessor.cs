using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.OCP_OpenClosePrinciple.GoodCode
{
    public class PaymenyProcessor
    {
        public void processPayment(PaymentMethod paymentMethod, string amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
