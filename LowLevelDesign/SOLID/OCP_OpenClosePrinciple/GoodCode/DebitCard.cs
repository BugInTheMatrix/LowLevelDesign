using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.OCP_OpenClosePrinciple.GoodCode
{
    public class DebitCard : PaymentMethod
    {
        public void Pay(string amount)
        {
            Console.WriteLine("this is a debitcard payment");
        }
    }
}
