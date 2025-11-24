using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.SRP_SIngleResponsibilityPrinciple.GoodCode
{
    public class InvoiceGood
    {
        private double amount;

        public InvoiceGood(double amount)
        {
            this.amount = amount;
        }

        //Additional Functionality
        public void generateInvoice()
        {
            Console.WriteLine("Invoice generated & printed for amount " + amount);
        }
    }
}
