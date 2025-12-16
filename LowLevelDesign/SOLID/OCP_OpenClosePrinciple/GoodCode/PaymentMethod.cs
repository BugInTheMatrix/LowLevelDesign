using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.OCP_OpenClosePrinciple.GoodCode
{
    public interface PaymentMethod
    {
        void Pay(string amount);
    }
}
