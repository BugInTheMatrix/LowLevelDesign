using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.SOLID.SRP_SIngleResponsibilityPrinciple.BadCode
{
    public class InvoiceBad
    {
        private double amount;

        public InvoiceBad(double amount)
        {
            this.amount = amount;
        }

        //Additional Functionality
        public void generateInvoice()
        {
            Console.WriteLine("Invoice generated & printed for amount " + amount);
        }

        public void saveToDatabase()
        {
            Console.WriteLine("Saving invoice to Database ");
        }

        public void sendEmailNotification()
        {
            Console.WriteLine("Sending email notification for invoice ");
        }
    }
}
