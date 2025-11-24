using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.OOPS
{
    public class UPI : PaymentMethod
    {
        private string upiId;
        public UPI(string upiId)
        {
            this.upiId = upiId;
        }
        public void Pay()
        {
            Console.WriteLine($"Payment made using UPI ID: {upiId}");
        }
    }
}
