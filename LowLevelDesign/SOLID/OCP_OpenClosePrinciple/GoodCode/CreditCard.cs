using LowLevelDesign.SOLID.OCP_OpenClosePrinciple.BadCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.OCP_OpenClosePrinciple.GoodCode
{
    public class CreditCard : PaymentMethod
    {
        public void Pay(string amount)
        {
            Console.WriteLine("this is creditcard pyment");
        }
    }
}
